using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002FA RID: 762
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "EventInfoDisappearCondition")]
	[Serializable]
	public class EventInfoDisappearCondition : IExtensible
	{
		// Token: 0x06002DED RID: 11757 RVA: 0x000B805C File Offset: 0x000B625C
		public EventInfoDisappearCondition()
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

		// Token: 0x17000CE9 RID: 3305
		// (get) Token: 0x06002DEE RID: 11758 RVA: 0x000B80C4 File Offset: 0x000B62C4
		// (set) Token: 0x06002DEF RID: 11759 RVA: 0x000B80CC File Offset: 0x000B62CC
		[ProtoMember(1, IsRequired = true, Name = "ConditionType", DataFormat = DataFormat.TwosComplement)]
		public EventDisappearConditionType ConditionType
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

		// Token: 0x17000CEA RID: 3306
		// (get) Token: 0x06002DF0 RID: 11760 RVA: 0x000B80D8 File Offset: 0x000B62D8
		// (set) Token: 0x06002DF1 RID: 11761 RVA: 0x000B80E0 File Offset: 0x000B62E0
		[ProtoMember(2, IsRequired = true, Name = "Param", DataFormat = DataFormat.TwosComplement)]
		public int Param
		{
			get
			{
				return this._Param;
			}
			set
			{
				this._Param = value;
			}
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x000B80EC File Offset: 0x000B62EC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x000B80FC File Offset: 0x000B62FC
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

		// Token: 0x06002DF4 RID: 11764 RVA: 0x000B81C8 File Offset: 0x000B63C8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(EventInfoDisappearCondition));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002343 RID: 9027
		private EventDisappearConditionType _ConditionType;

		// Token: 0x04002344 RID: 9028
		private int _Param;

		// Token: 0x04002345 RID: 9029
		private IExtension extensionObject;

		// Token: 0x04002346 RID: 9030
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002347 RID: 9031
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002348 RID: 9032
		private LuaFunction m_ctor_hotfix;
	}
}
