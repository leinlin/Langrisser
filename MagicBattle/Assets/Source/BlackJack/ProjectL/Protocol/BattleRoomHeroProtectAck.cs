using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005EF RID: 1519
	[ProtoContract(Name = "BattleRoomHeroProtectAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class BattleRoomHeroProtectAck : IExtensible
	{
		// Token: 0x06005498 RID: 21656 RVA: 0x0018EEF0 File Offset: 0x0018D0F0
		public BattleRoomHeroProtectAck()
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

		// Token: 0x170014C0 RID: 5312
		// (get) Token: 0x06005499 RID: 21657 RVA: 0x0018EF58 File Offset: 0x0018D158
		// (set) Token: 0x0600549A RID: 21658 RVA: 0x0018EF60 File Offset: 0x0018D160
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

		// Token: 0x0600549B RID: 21659 RVA: 0x0018EF6C File Offset: 0x0018D16C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600549C RID: 21660 RVA: 0x0018EF7C File Offset: 0x0018D17C
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

		// Token: 0x0600549D RID: 21661 RVA: 0x0018F048 File Offset: 0x0018D248
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoomHeroProtectAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F92 RID: 16274
		private int _Result;

		// Token: 0x04003F93 RID: 16275
		private IExtension extensionObject;

		// Token: 0x04003F94 RID: 16276
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F95 RID: 16277
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F96 RID: 16278
		private LuaFunction m_ctor_hotfix;
	}
}
