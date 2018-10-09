using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005C8 RID: 1480
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaBattleReportBasicDataGetAck")]
	[Serializable]
	public class ArenaBattleReportBasicDataGetAck : IExtensible
	{
		// Token: 0x0600535E RID: 21342 RVA: 0x0018A72C File Offset: 0x0018892C
		public ArenaBattleReportBasicDataGetAck()
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

		// Token: 0x1700146C RID: 5228
		// (get) Token: 0x0600535F RID: 21343 RVA: 0x0018A7A0 File Offset: 0x001889A0
		// (set) Token: 0x06005360 RID: 21344 RVA: 0x0018A7A8 File Offset: 0x001889A8
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

		// Token: 0x1700146D RID: 5229
		// (get) Token: 0x06005361 RID: 21345 RVA: 0x0018A7B4 File Offset: 0x001889B4
		[ProtoMember(2, Name = "ArenaReports", DataFormat = DataFormat.Default)]
		public List<ProArenaBattleReport> ArenaReports
		{
			get
			{
				return this._ArenaReports;
			}
		}

		// Token: 0x1700146E RID: 5230
		// (get) Token: 0x06005362 RID: 21346 RVA: 0x0018A7BC File Offset: 0x001889BC
		// (set) Token: 0x06005363 RID: 21347 RVA: 0x0018A7C4 File Offset: 0x001889C4
		[ProtoMember(3, IsRequired = true, Name = "NextBattleReportIndex", DataFormat = DataFormat.TwosComplement)]
		public int NextBattleReportIndex
		{
			get
			{
				return this._NextBattleReportIndex;
			}
			set
			{
				this._NextBattleReportIndex = value;
			}
		}

		// Token: 0x06005364 RID: 21348 RVA: 0x0018A7D0 File Offset: 0x001889D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005365 RID: 21349 RVA: 0x0018A7E0 File Offset: 0x001889E0
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

		// Token: 0x06005366 RID: 21350 RVA: 0x0018A8AC File Offset: 0x00188AAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaBattleReportBasicDataGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EA2 RID: 16034
		private int _Result;

		// Token: 0x04003EA3 RID: 16035
		private readonly List<ProArenaBattleReport> _ArenaReports = new List<ProArenaBattleReport>();

		// Token: 0x04003EA4 RID: 16036
		private int _NextBattleReportIndex;

		// Token: 0x04003EA5 RID: 16037
		private IExtension extensionObject;

		// Token: 0x04003EA6 RID: 16038
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EA7 RID: 16039
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EA8 RID: 16040
		private LuaFunction m_ctor_hotfix;
	}
}
