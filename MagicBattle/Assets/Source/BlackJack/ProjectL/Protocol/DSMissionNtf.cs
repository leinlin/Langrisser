using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000721 RID: 1825
	[ProtoContract(Name = "DSMissionNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSMissionNtf : IExtensible
	{
		// Token: 0x06006078 RID: 24696 RVA: 0x001B3BE0 File Offset: 0x001B1DE0
		public DSMissionNtf()
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

		// Token: 0x1700189B RID: 6299
		// (get) Token: 0x06006079 RID: 24697 RVA: 0x001B3C68 File Offset: 0x001B1E68
		// (set) Token: 0x0600607A RID: 24698 RVA: 0x001B3C70 File Offset: 0x001B1E70
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

		// Token: 0x1700189C RID: 6300
		// (get) Token: 0x0600607B RID: 24699 RVA: 0x001B3C7C File Offset: 0x001B1E7C
		[ProtoMember(2, Name = "FinishedEverydayMissionList", DataFormat = DataFormat.TwosComplement)]
		public List<int> FinishedEverydayMissionList
		{
			get
			{
				return this._FinishedEverydayMissionList;
			}
		}

		// Token: 0x1700189D RID: 6301
		// (get) Token: 0x0600607C RID: 24700 RVA: 0x001B3C84 File Offset: 0x001B1E84
		[ProtoMember(3, Name = "FinishedOneOffMissionList", DataFormat = DataFormat.TwosComplement)]
		public List<int> FinishedOneOffMissionList
		{
			get
			{
				return this._FinishedOneOffMissionList;
			}
		}

		// Token: 0x1700189E RID: 6302
		// (get) Token: 0x0600607D RID: 24701 RVA: 0x001B3C8C File Offset: 0x001B1E8C
		[ProtoMember(4, Name = "ProcessingMissionList", DataFormat = DataFormat.Default)]
		public List<ProMission> ProcessingMissionList
		{
			get
			{
				return this._ProcessingMissionList;
			}
		}

		// Token: 0x0600607E RID: 24702 RVA: 0x001B3C94 File Offset: 0x001B1E94
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600607F RID: 24703 RVA: 0x001B3CA4 File Offset: 0x001B1EA4
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

		// Token: 0x06006080 RID: 24704 RVA: 0x001B3D70 File Offset: 0x001B1F70
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSMissionNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004835 RID: 18485
		private uint _Version;

		// Token: 0x04004836 RID: 18486
		private readonly List<int> _FinishedEverydayMissionList = new List<int>();

		// Token: 0x04004837 RID: 18487
		private readonly List<int> _FinishedOneOffMissionList = new List<int>();

		// Token: 0x04004838 RID: 18488
		private readonly List<ProMission> _ProcessingMissionList = new List<ProMission>();

		// Token: 0x04004839 RID: 18489
		private IExtension extensionObject;

		// Token: 0x0400483A RID: 18490
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400483B RID: 18491
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400483C RID: 18492
		private LuaFunction m_ctor_hotfix;
	}
}
