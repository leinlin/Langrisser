using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005E3 RID: 1507
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "BattleArmyRandomSeedGetAck")]
	[Serializable]
	public class BattleArmyRandomSeedGetAck : IExtensible
	{
		// Token: 0x06005442 RID: 21570 RVA: 0x0018D964 File Offset: 0x0018BB64
		public BattleArmyRandomSeedGetAck()
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

		// Token: 0x170014AD RID: 5293
		// (get) Token: 0x06005443 RID: 21571 RVA: 0x0018D9CC File Offset: 0x0018BBCC
		// (set) Token: 0x06005444 RID: 21572 RVA: 0x0018D9D4 File Offset: 0x0018BBD4
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

		// Token: 0x170014AE RID: 5294
		// (get) Token: 0x06005445 RID: 21573 RVA: 0x0018D9E0 File Offset: 0x0018BBE0
		// (set) Token: 0x06005446 RID: 21574 RVA: 0x0018D9E8 File Offset: 0x0018BBE8
		[ProtoMember(2, IsRequired = true, Name = "BattleId", DataFormat = DataFormat.TwosComplement)]
		public int BattleId
		{
			get
			{
				return this._BattleId;
			}
			set
			{
				this._BattleId = value;
			}
		}

		// Token: 0x170014AF RID: 5295
		// (get) Token: 0x06005447 RID: 21575 RVA: 0x0018D9F4 File Offset: 0x0018BBF4
		// (set) Token: 0x06005448 RID: 21576 RVA: 0x0018D9FC File Offset: 0x0018BBFC
		[ProtoMember(3, IsRequired = true, Name = "ArmyRandomSeed", DataFormat = DataFormat.TwosComplement)]
		public int ArmyRandomSeed
		{
			get
			{
				return this._ArmyRandomSeed;
			}
			set
			{
				this._ArmyRandomSeed = value;
			}
		}

		// Token: 0x06005449 RID: 21577 RVA: 0x0018DA08 File Offset: 0x0018BC08
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600544A RID: 21578 RVA: 0x0018DA18 File Offset: 0x0018BC18
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

		// Token: 0x0600544B RID: 21579 RVA: 0x0018DAE4 File Offset: 0x0018BCE4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleArmyRandomSeedGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003F4F RID: 16207
		private int _Result;

		// Token: 0x04003F50 RID: 16208
		private int _BattleId;

		// Token: 0x04003F51 RID: 16209
		private int _ArmyRandomSeed;

		// Token: 0x04003F52 RID: 16210
		private IExtension extensionObject;

		// Token: 0x04003F53 RID: 16211
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003F54 RID: 16212
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003F55 RID: 16213
		private LuaFunction m_ctor_hotfix;
	}
}
