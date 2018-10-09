using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005C6 RID: 1478
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaBattleReportPlayBackDataGetAck")]
	[Serializable]
	public class ArenaBattleReportPlayBackDataGetAck : IExtensible
	{
		// Token: 0x06005350 RID: 21328 RVA: 0x0018A398 File Offset: 0x00188598
		public ArenaBattleReportPlayBackDataGetAck()
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

		// Token: 0x17001469 RID: 5225
		// (get) Token: 0x06005351 RID: 21329 RVA: 0x0018A400 File Offset: 0x00188600
		// (set) Token: 0x06005352 RID: 21330 RVA: 0x0018A408 File Offset: 0x00188608
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

		// Token: 0x1700146A RID: 5226
		// (get) Token: 0x06005353 RID: 21331 RVA: 0x0018A414 File Offset: 0x00188614
		// (set) Token: 0x06005354 RID: 21332 RVA: 0x0018A41C File Offset: 0x0018861C
		[ProtoMember(2, IsRequired = true, Name = "ArenaBattleReportInstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong ArenaBattleReportInstanceId
		{
			get
			{
				return this._ArenaBattleReportInstanceId;
			}
			set
			{
				this._ArenaBattleReportInstanceId = value;
			}
		}

		// Token: 0x1700146B RID: 5227
		// (get) Token: 0x06005355 RID: 21333 RVA: 0x0018A428 File Offset: 0x00188628
		// (set) Token: 0x06005356 RID: 21334 RVA: 0x0018A430 File Offset: 0x00188630
		[ProtoMember(3, IsRequired = false, Name = "BattlePlayBackData", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProArenaBattleReport BattlePlayBackData
		{
			get
			{
				return this._BattlePlayBackData;
			}
			set
			{
				this._BattlePlayBackData = value;
			}
		}

		// Token: 0x06005357 RID: 21335 RVA: 0x0018A43C File Offset: 0x0018863C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005358 RID: 21336 RVA: 0x0018A44C File Offset: 0x0018864C
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

		// Token: 0x06005359 RID: 21337 RVA: 0x0018A518 File Offset: 0x00188718
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaBattleReportPlayBackDataGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E97 RID: 16023
		private int _Result;

		// Token: 0x04003E98 RID: 16024
		private ulong _ArenaBattleReportInstanceId;

		// Token: 0x04003E99 RID: 16025
		private ProArenaBattleReport _BattlePlayBackData;

		// Token: 0x04003E9A RID: 16026
		private IExtension extensionObject;

		// Token: 0x04003E9B RID: 16027
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E9C RID: 16028
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E9D RID: 16029
		private LuaFunction m_ctor_hotfix;
	}
}
