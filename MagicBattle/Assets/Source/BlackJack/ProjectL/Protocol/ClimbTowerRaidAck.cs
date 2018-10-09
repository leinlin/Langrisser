using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000636 RID: 1590
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ClimbTowerRaidAck")]
	[Serializable]
	public class ClimbTowerRaidAck : IExtensible
	{
		// Token: 0x06005715 RID: 22293 RVA: 0x001974C8 File Offset: 0x001956C8
		public ClimbTowerRaidAck()
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

		// Token: 0x1700157F RID: 5503
		// (get) Token: 0x06005716 RID: 22294 RVA: 0x0019753C File Offset: 0x0019573C
		// (set) Token: 0x06005717 RID: 22295 RVA: 0x00197544 File Offset: 0x00195744
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

		// Token: 0x17001580 RID: 5504
		// (get) Token: 0x06005718 RID: 22296 RVA: 0x00197550 File Offset: 0x00195750
		// (set) Token: 0x06005719 RID: 22297 RVA: 0x00197558 File Offset: 0x00195758
		[ProtoMember(2, IsRequired = true, Name = "FloorId", DataFormat = DataFormat.TwosComplement)]
		public int FloorId
		{
			get
			{
				return this._FloorId;
			}
			set
			{
				this._FloorId = value;
			}
		}

		// Token: 0x17001581 RID: 5505
		// (get) Token: 0x0600571A RID: 22298 RVA: 0x00197564 File Offset: 0x00195764
		// (set) Token: 0x0600571B RID: 22299 RVA: 0x0019756C File Offset: 0x0019576C
		[ProtoMember(3, IsRequired = true, Name = "Ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x17001582 RID: 5506
		// (get) Token: 0x0600571C RID: 22300 RVA: 0x00197578 File Offset: 0x00195778
		[ProtoMember(4, Name = "NormalRewards", DataFormat = DataFormat.Default)]
		public List<ProGoods> NormalRewards
		{
			get
			{
				return this._NormalRewards;
			}
		}

		// Token: 0x0600571D RID: 22301 RVA: 0x00197580 File Offset: 0x00195780
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600571E RID: 22302 RVA: 0x00197590 File Offset: 0x00195790
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

		// Token: 0x0600571F RID: 22303 RVA: 0x0019765C File Offset: 0x0019585C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerRaidAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400416D RID: 16749
		private int _Result;

		// Token: 0x0400416E RID: 16750
		private int _FloorId;

		// Token: 0x0400416F RID: 16751
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004170 RID: 16752
		private readonly List<ProGoods> _NormalRewards = new List<ProGoods>();

		// Token: 0x04004171 RID: 16753
		private IExtension extensionObject;

		// Token: 0x04004172 RID: 16754
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004173 RID: 16755
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004174 RID: 16756
		private LuaFunction m_ctor_hotfix;
	}
}
