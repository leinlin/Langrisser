using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200078E RID: 1934
	[ProtoContract(Name = "GuildMassiveCombatDataAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildMassiveCombatDataAck : IExtensible
	{
		// Token: 0x060063BA RID: 25530 RVA: 0x001C0340 File Offset: 0x001BE540
		public GuildMassiveCombatDataAck()
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

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x060063BB RID: 25531 RVA: 0x001C03A8 File Offset: 0x001BE5A8
		// (set) Token: 0x060063BC RID: 25532 RVA: 0x001C03B0 File Offset: 0x001BE5B0
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

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x060063BD RID: 25533 RVA: 0x001C03BC File Offset: 0x001BE5BC
		// (set) Token: 0x060063BE RID: 25534 RVA: 0x001C03C4 File Offset: 0x001BE5C4
		[ProtoMember(2, IsRequired = true, Name = "GeneralInfo", DataFormat = DataFormat.Default)]
		public ProGuildMassiveCombatGeneralInfo GeneralInfo
		{
			get
			{
				return this._GeneralInfo;
			}
			set
			{
				this._GeneralInfo = value;
			}
		}

		// Token: 0x060063BF RID: 25535 RVA: 0x001C03D0 File Offset: 0x001BE5D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060063C0 RID: 25536 RVA: 0x001C03E0 File Offset: 0x001BE5E0
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

		// Token: 0x060063C1 RID: 25537 RVA: 0x001C04AC File Offset: 0x001BE6AC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatDataAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AC4 RID: 19140
		private int _Result;

		// Token: 0x04004AC5 RID: 19141
		private ProGuildMassiveCombatGeneralInfo _GeneralInfo;

		// Token: 0x04004AC6 RID: 19142
		private IExtension extensionObject;

		// Token: 0x04004AC7 RID: 19143
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AC8 RID: 19144
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AC9 RID: 19145
		private LuaFunction m_ctor_hotfix;
	}
}
