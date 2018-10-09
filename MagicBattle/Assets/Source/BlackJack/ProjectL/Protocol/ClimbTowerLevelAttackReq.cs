using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000631 RID: 1585
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ClimbTowerLevelAttackReq")]
	[Serializable]
	public class ClimbTowerLevelAttackReq : IExtensible
	{
		// Token: 0x060056E9 RID: 22249 RVA: 0x00196B6C File Offset: 0x00194D6C
		public ClimbTowerLevelAttackReq()
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

		// Token: 0x17001572 RID: 5490
		// (get) Token: 0x060056EA RID: 22250 RVA: 0x00196BD4 File Offset: 0x00194DD4
		// (set) Token: 0x060056EB RID: 22251 RVA: 0x00196BDC File Offset: 0x00194DDC
		[ProtoMember(1, IsRequired = true, Name = "FloorId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x060056EC RID: 22252 RVA: 0x00196BE8 File Offset: 0x00194DE8
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x00196BF8 File Offset: 0x00194DF8
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

		// Token: 0x060056EE RID: 22254 RVA: 0x00196CC4 File Offset: 0x00194EC4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerLevelAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400414C RID: 16716
		private int _FloorId;

		// Token: 0x0400414D RID: 16717
		private IExtension extensionObject;

		// Token: 0x0400414E RID: 16718
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400414F RID: 16719
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004150 RID: 16720
		private LuaFunction m_ctor_hotfix;
	}
}
