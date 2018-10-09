using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005E9 RID: 1513
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleRoomHeroSetupAck")]
	[Serializable]
	public class BattleRoomHeroSetupAck : IExtensible
	{
		// Token: 0x0600546C RID: 21612 RVA: 0x0018E420 File Offset: 0x0018C620
		public BattleRoomHeroSetupAck()
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

		// Token: 0x170014B6 RID: 5302
		// (get) Token: 0x0600546D RID: 21613 RVA: 0x0018E488 File Offset: 0x0018C688
		// (set) Token: 0x0600546E RID: 21614 RVA: 0x0018E490 File Offset: 0x0018C690
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

		// Token: 0x0600546F RID: 21615 RVA: 0x0018E49C File Offset: 0x0018C69C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005470 RID: 21616 RVA: 0x0018E4AC File Offset: 0x0018C6AC
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

		// Token: 0x06005471 RID: 21617 RVA: 0x0018E578 File Offset: 0x0018C778
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroSetupAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F70 RID: 16240
		private int _Result;

		// Token: 0x04003F71 RID: 16241
		private IExtension extensionObject;

		// Token: 0x04003F72 RID: 16242
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F73 RID: 16243
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F74 RID: 16244
		private LuaFunction m_ctor_hotfix;
	}
}
