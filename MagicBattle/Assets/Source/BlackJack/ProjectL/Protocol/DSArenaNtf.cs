using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000726 RID: 1830
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSArenaNtf")]
	[Serializable]
	public class DSArenaNtf : IExtensible
	{
		// Token: 0x060060A7 RID: 24743 RVA: 0x001B45C0 File Offset: 0x001B27C0
		public DSArenaNtf()
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

		// Token: 0x170018AF RID: 6319
		// (get) Token: 0x060060A8 RID: 24744 RVA: 0x001B4628 File Offset: 0x001B2828
		// (set) Token: 0x060060A9 RID: 24745 RVA: 0x001B4630 File Offset: 0x001B2830
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018B0 RID: 6320
		// (get) Token: 0x060060AA RID: 24746 RVA: 0x001B463C File Offset: 0x001B283C
		// (set) Token: 0x060060AB RID: 24747 RVA: 0x001B4644 File Offset: 0x001B2844
		[ProtoMember(2, IsRequired = true, Name = "ArenaPlayerData", DataFormat = DataFormat.Default)]
		public ProArenaPlayerInfo ArenaPlayerData
		{
			get
			{
				return this._ArenaPlayerData;
			}
			set
			{
				this._ArenaPlayerData = value;
			}
		}

		// Token: 0x060060AC RID: 24748 RVA: 0x001B4650 File Offset: 0x001B2850
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060060AD RID: 24749 RVA: 0x001B4660 File Offset: 0x001B2860
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

		// Token: 0x060060AE RID: 24750 RVA: 0x001B472C File Offset: 0x001B292C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSArenaNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400485D RID: 18525
		private uint _Version;

		// Token: 0x0400485E RID: 18526
		private ProArenaPlayerInfo _ArenaPlayerData;

		// Token: 0x0400485F RID: 18527
		private IExtension extensionObject;

		// Token: 0x04004860 RID: 18528
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004861 RID: 18529
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004862 RID: 18530
		private LuaFunction m_ctor_hotfix;
	}
}
