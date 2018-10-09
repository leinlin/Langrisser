using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000630 RID: 1584
	[ProtoContract(Name = "ClimbTowerGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ClimbTowerGetAck : IExtensible
	{
		// Token: 0x060056DD RID: 22237 RVA: 0x00196970 File Offset: 0x00194B70
		public ClimbTowerGetAck()
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

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x060056DE RID: 22238 RVA: 0x001969D8 File Offset: 0x00194BD8
		// (set) Token: 0x060056DF RID: 22239 RVA: 0x001969E0 File Offset: 0x00194BE0
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

		// Token: 0x1700156F RID: 5487
		// (get) Token: 0x060056E0 RID: 22240 RVA: 0x001969EC File Offset: 0x00194BEC
		// (set) Token: 0x060056E1 RID: 22241 RVA: 0x001969F4 File Offset: 0x00194BF4
		[ProtoMember(2, IsRequired = true, Name = "ClimbTower", DataFormat = DataFormat.Default)]
		public ProClimbTower ClimbTower
		{
			get
			{
				return this._ClimbTower;
			}
			set
			{
				this._ClimbTower = value;
			}
		}

		// Token: 0x17001570 RID: 5488
		// (get) Token: 0x060056E2 RID: 22242 RVA: 0x00196A00 File Offset: 0x00194C00
		// (set) Token: 0x060056E3 RID: 22243 RVA: 0x00196A08 File Offset: 0x00194C08
		[ProtoMember(3, IsRequired = true, Name = "Floor", DataFormat = DataFormat.TwosComplement)]
		public int Floor
		{
			get
			{
				return this._Floor;
			}
			set
			{
				this._Floor = value;
			}
		}

		// Token: 0x17001571 RID: 5489
		// (get) Token: 0x060056E4 RID: 22244 RVA: 0x00196A14 File Offset: 0x00194C14
		// (set) Token: 0x060056E5 RID: 22245 RVA: 0x00196A1C File Offset: 0x00194C1C
		[ProtoMember(4, IsRequired = true, Name = "HistoryFloorMax", DataFormat = DataFormat.TwosComplement)]
		public int HistoryFloorMax
		{
			get
			{
				return this._HistoryFloorMax;
			}
			set
			{
				this._HistoryFloorMax = value;
			}
		}

		// Token: 0x060056E6 RID: 22246 RVA: 0x00196A28 File Offset: 0x00194C28
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060056E7 RID: 22247 RVA: 0x00196A38 File Offset: 0x00194C38
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

		// Token: 0x060056E8 RID: 22248 RVA: 0x00196B04 File Offset: 0x00194D04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004144 RID: 16708
		private int _Result;

		// Token: 0x04004145 RID: 16709
		private ProClimbTower _ClimbTower;

		// Token: 0x04004146 RID: 16710
		private int _Floor;

		// Token: 0x04004147 RID: 16711
		private int _HistoryFloorMax;

		// Token: 0x04004148 RID: 16712
		private IExtension extensionObject;

		// Token: 0x04004149 RID: 16713
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400414A RID: 16714
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400414B RID: 16715
		private LuaFunction m_ctor_hotfix;
	}
}
