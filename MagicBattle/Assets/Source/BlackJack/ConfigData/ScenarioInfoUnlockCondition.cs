using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x020002F8 RID: 760
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ScenarioInfoUnlockCondition")]
	[Serializable]
	public class ScenarioInfoUnlockCondition : IExtensible
	{
		// Token: 0x06002DDB RID: 11739 RVA: 0x000B7CA0 File Offset: 0x000B5EA0
		public ScenarioInfoUnlockCondition()
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

		// Token: 0x17000CE4 RID: 3300
		// (get) Token: 0x06002DDC RID: 11740 RVA: 0x000B7D08 File Offset: 0x000B5F08
		// (set) Token: 0x06002DDD RID: 11741 RVA: 0x000B7D10 File Offset: 0x000B5F10
		[ProtoMember(1, IsRequired = true, Name = "ConditionType", DataFormat = DataFormat.TwosComplement)]
		public ScenarioUnlockConditionType ConditionType
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

		// Token: 0x17000CE5 RID: 3301
		// (get) Token: 0x06002DDE RID: 11742 RVA: 0x000B7D1C File Offset: 0x000B5F1C
		// (set) Token: 0x06002DDF RID: 11743 RVA: 0x000B7D24 File Offset: 0x000B5F24
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

		// Token: 0x06002DE0 RID: 11744 RVA: 0x000B7D30 File Offset: 0x000B5F30
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x000B7D40 File Offset: 0x000B5F40
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

		// Token: 0x06002DE2 RID: 11746 RVA: 0x000B7E0C File Offset: 0x000B600C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ScenarioInfoUnlockCondition));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002336 RID: 9014
		private ScenarioUnlockConditionType _ConditionType;

		// Token: 0x04002337 RID: 9015
		private int _Param;

		// Token: 0x04002338 RID: 9016
		private IExtension extensionObject;

		// Token: 0x04002339 RID: 9017
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400233A RID: 9018
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400233B RID: 9019
		private LuaFunction m_ctor_hotfix;
	}
}
