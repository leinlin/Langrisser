using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000649 RID: 1609
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProBattleReport")]
	[Serializable]
	public class ProBattleReport : IExtensible
	{
		// Token: 0x060057F3 RID: 22515 RVA: 0x00199AAC File Offset: 0x00197CAC
		public ProBattleReport()
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

		// Token: 0x170015CE RID: 5582
		// (get) Token: 0x060057F4 RID: 22516 RVA: 0x00199B34 File Offset: 0x00197D34
		[ProtoMember(2, Name = "MineCommands", DataFormat = DataFormat.Default)]
		public List<ProBattleCommand> MineCommands
		{
			get
			{
				return this._MineCommands;
			}
		}

		// Token: 0x170015CF RID: 5583
		// (get) Token: 0x060057F5 RID: 22517 RVA: 0x00199B3C File Offset: 0x00197D3C
		[ProtoMember(3, Name = "OpponentCommands", DataFormat = DataFormat.Default)]
		public List<ProBattleCommand> OpponentCommands
		{
			get
			{
				return this._OpponentCommands;
			}
		}

		// Token: 0x170015D0 RID: 5584
		// (get) Token: 0x060057F6 RID: 22518 RVA: 0x00199B44 File Offset: 0x00197D44
		// (set) Token: 0x060057F7 RID: 22519 RVA: 0x00199B4C File Offset: 0x00197D4C
		[DefaultValue("")]
		[ProtoMember(4, IsRequired = false, Name = "BattleTeamsSetupLog", DataFormat = DataFormat.Default)]
		public string BattleTeamsSetupLog
		{
			get
			{
				return this._BattleTeamsSetupLog;
			}
			set
			{
				this._BattleTeamsSetupLog = value;
			}
		}

		// Token: 0x060057F8 RID: 22520 RVA: 0x00199B58 File Offset: 0x00197D58
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060057F9 RID: 22521 RVA: 0x00199B68 File Offset: 0x00197D68
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

		// Token: 0x060057FA RID: 22522 RVA: 0x00199C34 File Offset: 0x00197E34
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBattleReport));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004208 RID: 16904
		private readonly List<ProBattleCommand> _MineCommands = new List<ProBattleCommand>();

		// Token: 0x04004209 RID: 16905
		private readonly List<ProBattleCommand> _OpponentCommands = new List<ProBattleCommand>();

		// Token: 0x0400420A RID: 16906
		private string _BattleTeamsSetupLog = string.Empty;

		// Token: 0x0400420B RID: 16907
		private IExtension extensionObject;

		// Token: 0x0400420C RID: 16908
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400420D RID: 16909
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400420E RID: 16910
		private LuaFunction m_ctor_hotfix;
	}
}
