using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200024D RID: 589
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ConfigDataHeroPerformanceInfo")]
	[Serializable]
	public class ConfigDataHeroPerformanceInfo : IExtensible
	{
		// Token: 0x060024AF RID: 9391 RVA: 0x000A7988 File Offset: 0x000A5B88
		public ConfigDataHeroPerformanceInfo()
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

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060024B0 RID: 9392 RVA: 0x000A79FC File Offset: 0x000A5BFC
		// (set) Token: 0x060024B1 RID: 9393 RVA: 0x000A7A04 File Offset: 0x000A5C04
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

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x000A7A10 File Offset: 0x000A5C10
		// (set) Token: 0x060024B3 RID: 9395 RVA: 0x000A7A18 File Offset: 0x000A5C18
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060024B4 RID: 9396 RVA: 0x000A7A24 File Offset: 0x000A5C24
		// (set) Token: 0x060024B5 RID: 9397 RVA: 0x000A7A2C File Offset: 0x000A5C2C
		[ProtoMember(4, IsRequired = true, Name = "Word", DataFormat = DataFormat.Default)]
		public string Word
		{
			get
			{
				return this._Word;
			}
			set
			{
				this._Word = value;
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060024B6 RID: 9398 RVA: 0x000A7A38 File Offset: 0x000A5C38
		// (set) Token: 0x060024B7 RID: 9399 RVA: 0x000A7A40 File Offset: 0x000A5C40
		[ProtoMember(5, IsRequired = true, Name = "Animation", DataFormat = DataFormat.Default)]
		public string Animation
		{
			get
			{
				return this._Animation;
			}
			set
			{
				this._Animation = value;
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060024B8 RID: 9400 RVA: 0x000A7A4C File Offset: 0x000A5C4C
		// (set) Token: 0x060024B9 RID: 9401 RVA: 0x000A7A54 File Offset: 0x000A5C54
		[ProtoMember(6, IsRequired = true, Name = "Voice", DataFormat = DataFormat.Default)]
		public string Voice
		{
			get
			{
				return this._Voice;
			}
			set
			{
				this._Voice = value;
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x060024BA RID: 9402 RVA: 0x000A7A60 File Offset: 0x000A5C60
		[ProtoMember(7, Name = "UnlockConditions", DataFormat = DataFormat.Default)]
		public List<HeroPerformanceUnlcokCondition> UnlockConditions
		{
			get
			{
				return this._UnlockConditions;
			}
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x000A7A68 File Offset: 0x000A5C68
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x000A7A78 File Offset: 0x000A5C78
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

		// Token: 0x060024BD RID: 9405 RVA: 0x000A7B44 File Offset: 0x000A5D44
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroPerformanceInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04001663 RID: 5731
		private int _ID;

		// Token: 0x04001664 RID: 5732
		private string _Name;

		// Token: 0x04001665 RID: 5733
		private string _Word;

		// Token: 0x04001666 RID: 5734
		private string _Animation;

		// Token: 0x04001667 RID: 5735
		private string _Voice;

		// Token: 0x04001668 RID: 5736
		private readonly List<HeroPerformanceUnlcokCondition> _UnlockConditions = new List<HeroPerformanceUnlcokCondition>();

		// Token: 0x04001669 RID: 5737
		private IExtension extensionObject;

		// Token: 0x0400166A RID: 5738
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400166B RID: 5739
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400166C RID: 5740
		private LuaFunction m_ctor_hotfix;
	}
}
