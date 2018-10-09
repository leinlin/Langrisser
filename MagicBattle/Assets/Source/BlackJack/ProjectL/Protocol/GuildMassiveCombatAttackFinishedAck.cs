using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000792 RID: 1938
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildMassiveCombatAttackFinishedAck")]
	[Serializable]
	public class GuildMassiveCombatAttackFinishedAck : IExtensible
	{
		// Token: 0x060063DD RID: 25565 RVA: 0x001C0AB8 File Offset: 0x001BECB8
		public GuildMassiveCombatAttackFinishedAck()
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

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x060063DE RID: 25566 RVA: 0x001C0B20 File Offset: 0x001BED20
		// (set) Token: 0x060063DF RID: 25567 RVA: 0x001C0B28 File Offset: 0x001BED28
		[ProtoMember(1, IsRequired = true, Name = "req", DataFormat = DataFormat.Default)]
		public GuildMassiveCombatAttackFinishedReq Req
		{
			get
			{
				return this._req;
			}
			set
			{
				this._req = value;
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x060063E0 RID: 25568 RVA: 0x001C0B34 File Offset: 0x001BED34
		// (set) Token: 0x060063E1 RID: 25569 RVA: 0x001C0B3C File Offset: 0x001BED3C
		[ProtoMember(2, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x060063E2 RID: 25570 RVA: 0x001C0B48 File Offset: 0x001BED48
		// (set) Token: 0x060063E3 RID: 25571 RVA: 0x001C0B50 File Offset: 0x001BED50
		[ProtoMember(3, IsRequired = true, Name = "ntf", DataFormat = DataFormat.Default)]
		public ProGuildMassiveCombatAttackResultNtf Ntf
		{
			get
			{
				return this._ntf;
			}
			set
			{
				this._ntf = value;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x060063E4 RID: 25572 RVA: 0x001C0B5C File Offset: 0x001BED5C
		// (set) Token: 0x060063E5 RID: 25573 RVA: 0x001C0B64 File Offset: 0x001BED64
		[ProtoMember(4, IsRequired = true, Name = "Win", DataFormat = DataFormat.Default)]
		public bool Win
		{
			get
			{
				return this._Win;
			}
			set
			{
				this._Win = value;
			}
		}

		// Token: 0x060063E6 RID: 25574 RVA: 0x001C0B70 File Offset: 0x001BED70
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060063E7 RID: 25575 RVA: 0x001C0B80 File Offset: 0x001BED80
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

		// Token: 0x060063E8 RID: 25576 RVA: 0x001C0C4C File Offset: 0x001BEE4C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatAttackFinishedAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004ADE RID: 19166
		private GuildMassiveCombatAttackFinishedReq _req;

		// Token: 0x04004ADF RID: 19167
		private int _Result;

		// Token: 0x04004AE0 RID: 19168
		private ProGuildMassiveCombatAttackResultNtf _ntf;

		// Token: 0x04004AE1 RID: 19169
		private bool _Win;

		// Token: 0x04004AE2 RID: 19170
		private IExtension extensionObject;

		// Token: 0x04004AE3 RID: 19171
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AE4 RID: 19172
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AE5 RID: 19173
		private LuaFunction m_ctor_hotfix;
	}
}
