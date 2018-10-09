using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000814 RID: 2068
	[ProtoContract(Name = "RealTimePVPGetTopPlayersAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RealTimePVPGetTopPlayersAck : IExtensible
	{
		// Token: 0x0600685F RID: 26719 RVA: 0x001D71D4 File Offset: 0x001D53D4
		public RealTimePVPGetTopPlayersAck()
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

		// Token: 0x17001ACA RID: 6858
		// (get) Token: 0x06006860 RID: 26720 RVA: 0x001D7250 File Offset: 0x001D5450
		// (set) Token: 0x06006861 RID: 26721 RVA: 0x001D7258 File Offset: 0x001D5458
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

		// Token: 0x17001ACB RID: 6859
		// (get) Token: 0x06006862 RID: 26722 RVA: 0x001D7264 File Offset: 0x001D5464
		[ProtoMember(2, Name = "Infos", DataFormat = DataFormat.Default)]
		public List<ProRealTimePVPLeaderboardPlayerInfo> Infos
		{
			get
			{
				return this._Infos;
			}
		}

		// Token: 0x17001ACC RID: 6860
		// (get) Token: 0x06006863 RID: 26723 RVA: 0x001D726C File Offset: 0x001D546C
		[ProtoMember(3, Name = "Summaries", DataFormat = DataFormat.Default)]
		public List<ProUserSummary> Summaries
		{
			get
			{
				return this._Summaries;
			}
		}

		// Token: 0x06006864 RID: 26724 RVA: 0x001D7274 File Offset: 0x001D5474
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006865 RID: 26725 RVA: 0x001D7284 File Offset: 0x001D5484
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

		// Token: 0x06006866 RID: 26726 RVA: 0x001D7350 File Offset: 0x001D5550
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RealTimePVPGetTopPlayersAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005070 RID: 20592
		private int _Result;

		// Token: 0x04005071 RID: 20593
		private readonly List<ProRealTimePVPLeaderboardPlayerInfo> _Infos = new List<ProRealTimePVPLeaderboardPlayerInfo>();

		// Token: 0x04005072 RID: 20594
		private readonly List<ProUserSummary> _Summaries = new List<ProUserSummary>();

		// Token: 0x04005073 RID: 20595
		private IExtension extensionObject;

		// Token: 0x04005074 RID: 20596
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005075 RID: 20597
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005076 RID: 20598
		private LuaFunction m_ctor_hotfix;
	}
}
