using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000313 RID: 787
	[ProtoContract(Name = "Soldier2SkinResource")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class Soldier2SkinResource : IExtensible
	{
		// Token: 0x06002EE3 RID: 12003 RVA: 0x000BAFDC File Offset: 0x000B91DC
		public Soldier2SkinResource()
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

		// Token: 0x17000D32 RID: 3378
		// (get) Token: 0x06002EE4 RID: 12004 RVA: 0x000BB044 File Offset: 0x000B9244
		// (set) Token: 0x06002EE5 RID: 12005 RVA: 0x000BB04C File Offset: 0x000B924C
		[ProtoMember(1, IsRequired = true, Name = "SoldierId", DataFormat = DataFormat.TwosComplement)]
		public int SoldierId
		{
			get
			{
				return this._SoldierId;
			}
			set
			{
				this._SoldierId = value;
			}
		}

		// Token: 0x17000D33 RID: 3379
		// (get) Token: 0x06002EE6 RID: 12006 RVA: 0x000BB058 File Offset: 0x000B9258
		// (set) Token: 0x06002EE7 RID: 12007 RVA: 0x000BB060 File Offset: 0x000B9260
		[ProtoMember(2, IsRequired = true, Name = "SkinResourceId", DataFormat = DataFormat.TwosComplement)]
		public int SkinResourceId
		{
			get
			{
				return this._SkinResourceId;
			}
			set
			{
				this._SkinResourceId = value;
			}
		}

		// Token: 0x06002EE8 RID: 12008 RVA: 0x000BB06C File Offset: 0x000B926C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x000BB07C File Offset: 0x000B927C
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

		// Token: 0x06002EEA RID: 12010 RVA: 0x000BB148 File Offset: 0x000B9348
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(Soldier2SkinResource));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023F0 RID: 9200
		private int _SoldierId;

		// Token: 0x040023F1 RID: 9201
		private int _SkinResourceId;

		// Token: 0x040023F2 RID: 9202
		private IExtension extensionObject;

		// Token: 0x040023F3 RID: 9203
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023F4 RID: 9204
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023F5 RID: 9205
		private LuaFunction m_ctor_hotfix;
	}
}
