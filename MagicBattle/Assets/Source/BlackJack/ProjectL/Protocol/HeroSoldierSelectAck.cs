using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007AE RID: 1966
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "HeroSoldierSelectAck")]
	[Serializable]
	public class HeroSoldierSelectAck : IExtensible
	{
		// Token: 0x060064E3 RID: 25827 RVA: 0x001C3FD0 File Offset: 0x001C21D0
		public HeroSoldierSelectAck()
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

		// Token: 0x170019D1 RID: 6609
		// (get) Token: 0x060064E4 RID: 25828 RVA: 0x001C4038 File Offset: 0x001C2238
		// (set) Token: 0x060064E5 RID: 25829 RVA: 0x001C4040 File Offset: 0x001C2240
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

		// Token: 0x170019D2 RID: 6610
		// (get) Token: 0x060064E6 RID: 25830 RVA: 0x001C404C File Offset: 0x001C224C
		// (set) Token: 0x060064E7 RID: 25831 RVA: 0x001C4054 File Offset: 0x001C2254
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x170019D3 RID: 6611
		// (get) Token: 0x060064E8 RID: 25832 RVA: 0x001C4060 File Offset: 0x001C2260
		// (set) Token: 0x060064E9 RID: 25833 RVA: 0x001C4068 File Offset: 0x001C2268
		[ProtoMember(3, IsRequired = true, Name = "SoldierId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060064EA RID: 25834 RVA: 0x001C4074 File Offset: 0x001C2274
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060064EB RID: 25835 RVA: 0x001C4084 File Offset: 0x001C2284
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

		// Token: 0x060064EC RID: 25836 RVA: 0x001C4150 File Offset: 0x001C2350
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroSoldierSelectAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004B9F RID: 19359
		private int _Result;

		// Token: 0x04004BA0 RID: 19360
		private int _HeroId;

		// Token: 0x04004BA1 RID: 19361
		private int _SoldierId;

		// Token: 0x04004BA2 RID: 19362
		private IExtension extensionObject;

		// Token: 0x04004BA3 RID: 19363
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BA4 RID: 19364
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BA5 RID: 19365
		private LuaFunction m_ctor_hotfix;
	}
}
