using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000317 RID: 791
	[ProtoContract(Name = "HeroFetterCompletionCondition")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroFetterCompletionCondition : IExtensible
	{
		// Token: 0x06002F05 RID: 12037 RVA: 0x000BB740 File Offset: 0x000B9940
		public HeroFetterCompletionCondition()
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

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002F06 RID: 12038 RVA: 0x000BB7A8 File Offset: 0x000B99A8
		// (set) Token: 0x06002F07 RID: 12039 RVA: 0x000BB7B0 File Offset: 0x000B99B0
		[ProtoMember(1, IsRequired = true, Name = "ConditionType", DataFormat = DataFormat.TwosComplement)]
		public FetterCompleteConditionType ConditionType
		{
			get
			{
				return this._ConditionType;
			}
			set
			{
				this._ConditionType = value;
			}
		}

		// Token: 0x17000D3C RID: 3388
		// (get) Token: 0x06002F08 RID: 12040 RVA: 0x000BB7BC File Offset: 0x000B99BC
		// (set) Token: 0x06002F09 RID: 12041 RVA: 0x000BB7C4 File Offset: 0x000B99C4
		[ProtoMember(2, IsRequired = true, Name = "Parm1", DataFormat = DataFormat.TwosComplement)]
		public int Parm1
		{
			get
			{
				return this._Parm1;
			}
			set
			{
				this._Parm1 = value;
			}
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x06002F0A RID: 12042 RVA: 0x000BB7D0 File Offset: 0x000B99D0
		// (set) Token: 0x06002F0B RID: 12043 RVA: 0x000BB7D8 File Offset: 0x000B99D8
		[ProtoMember(3, IsRequired = true, Name = "Parm2", DataFormat = DataFormat.TwosComplement)]
		public int Parm2
		{
			get
			{
				return this._Parm2;
			}
			set
			{
				this._Parm2 = value;
			}
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x000BB7E4 File Offset: 0x000B99E4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F0D RID: 12045 RVA: 0x000BB7F4 File Offset: 0x000B99F4
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

		// Token: 0x06002F0E RID: 12046 RVA: 0x000BB8C0 File Offset: 0x000B9AC0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroFetterCompletionCondition));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002409 RID: 9225
		private FetterCompleteConditionType _ConditionType;

		// Token: 0x0400240A RID: 9226
		private int _Parm1;

		// Token: 0x0400240B RID: 9227
		private int _Parm2;

		// Token: 0x0400240C RID: 9228
		private IExtension extensionObject;

		// Token: 0x0400240D RID: 9229
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400240E RID: 9230
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400240F RID: 9231
		private LuaFunction m_ctor_hotfix;
	}
}
