using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200074D RID: 1869
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "PullOrderRewardAck")]
	[Serializable]
	public class PullOrderRewardAck : IExtensible
	{
		// Token: 0x060061E8 RID: 25064 RVA: 0x001B8E2C File Offset: 0x001B702C
		public PullOrderRewardAck()
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

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x060061E9 RID: 25065 RVA: 0x001B8E94 File Offset: 0x001B7094
		// (set) Token: 0x060061EA RID: 25066 RVA: 0x001B8E9C File Offset: 0x001B709C
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060061EB RID: 25067 RVA: 0x001B8EA8 File Offset: 0x001B70A8
		// (set) Token: 0x060061EC RID: 25068 RVA: 0x001B8EB0 File Offset: 0x001B70B0
		[ProtoMember(2, IsRequired = true, Name = "OrderId", DataFormat = DataFormat.Default)]
		public string OrderId
		{
			get
			{
				return this._OrderId;
			}
			set
			{
				this._OrderId = value;
			}
		}

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060061ED RID: 25069 RVA: 0x001B8EBC File Offset: 0x001B70BC
		// (set) Token: 0x060061EE RID: 25070 RVA: 0x001B8EC4 File Offset: 0x001B70C4
		[ProtoMember(3, IsRequired = true, Name = "Reward", DataFormat = DataFormat.Default)]
		public ProOrderReward Reward
		{
			get
			{
				return this._Reward;
			}
			set
			{
				this._Reward = value;
			}
		}

		// Token: 0x060061EF RID: 25071 RVA: 0x001B8ED0 File Offset: 0x001B70D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060061F0 RID: 25072 RVA: 0x001B8EE0 File Offset: 0x001B70E0
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

		// Token: 0x060061F1 RID: 25073 RVA: 0x001B8FAC File Offset: 0x001B71AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PullOrderRewardAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004956 RID: 18774
		private int _Result;

		// Token: 0x04004957 RID: 18775
		private string _OrderId;

		// Token: 0x04004958 RID: 18776
		private ProOrderReward _Reward;

		// Token: 0x04004959 RID: 18777
		private IExtension extensionObject;

		// Token: 0x0400495A RID: 18778
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400495B RID: 18779
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400495C RID: 18780
		private LuaFunction m_ctor_hotfix;
	}
}
