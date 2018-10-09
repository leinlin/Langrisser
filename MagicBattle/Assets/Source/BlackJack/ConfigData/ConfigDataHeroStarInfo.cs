using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000252 RID: 594
	[ProtoContract(Name = "ConfigDataHeroStarInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ConfigDataHeroStarInfo : IExtensible
	{
		// Token: 0x06002521 RID: 9505 RVA: 0x000A85D8 File Offset: 0x000A67D8
		public ConfigDataHeroStarInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002522 RID: 9506 RVA: 0x000A8640 File Offset: 0x000A6840
		// (set) Token: 0x06002523 RID: 9507 RVA: 0x000A8648 File Offset: 0x000A6848
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002524 RID: 9508 RVA: 0x000A8654 File Offset: 0x000A6854
		// (set) Token: 0x06002525 RID: 9509 RVA: 0x000A865C File Offset: 0x000A685C
		[ProtoMember(3, IsRequired = true, Name = "Fragment", DataFormat = DataFormat.TwosComplement)]
		public int Fragment
		{
			get
			{
				return this._Fragment;
			}
			set
			{
				this._Fragment = value;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002526 RID: 9510 RVA: 0x000A8668 File Offset: 0x000A6868
		// (set) Token: 0x06002527 RID: 9511 RVA: 0x000A8670 File Offset: 0x000A6870
		[ProtoMember(4, IsRequired = true, Name = "Gold", DataFormat = DataFormat.TwosComplement)]
		public int Gold
		{
			get
			{
				return this._Gold;
			}
			set
			{
				this._Gold = value;
			}
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000A867C File Offset: 0x000A687C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000A868C File Offset: 0x000A688C
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x000A8758 File Offset: 0x000A6958
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroStarInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040016AF RID: 5807
		private int _ID;

		// Token: 0x040016B0 RID: 5808
		private int _Fragment;

		// Token: 0x040016B1 RID: 5809
		private int _Gold;

		// Token: 0x040016B2 RID: 5810
		private IExtension extensionObject;

		// Token: 0x040016B3 RID: 5811
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040016B4 RID: 5812
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040016B5 RID: 5813
		private LuaFunction m_ctor_hotfix;
	}
}
