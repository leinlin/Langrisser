using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007F6 RID: 2038
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GetMissionRewardAck")]
	[Serializable]
	public class GetMissionRewardAck : IExtensible
	{
		// Token: 0x06006770 RID: 26480 RVA: 0x001CC6F4 File Offset: 0x001CA8F4
		public GetMissionRewardAck()
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

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06006771 RID: 26481 RVA: 0x001CC75C File Offset: 0x001CA95C
		// (set) Token: 0x06006772 RID: 26482 RVA: 0x001CC764 File Offset: 0x001CA964
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

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x06006773 RID: 26483 RVA: 0x001CC770 File Offset: 0x001CA970
		// (set) Token: 0x06006774 RID: 26484 RVA: 0x001CC778 File Offset: 0x001CA978
		[ProtoMember(2, IsRequired = true, Name = "MissionId", DataFormat = DataFormat.TwosComplement)]
		public int MissionId
		{
			get
			{
				return this._MissionId;
			}
			set
			{
				this._MissionId = value;
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x06006775 RID: 26485 RVA: 0x001CC784 File Offset: 0x001CA984
		// (set) Token: 0x06006776 RID: 26486 RVA: 0x001CC78C File Offset: 0x001CA98C
		[ProtoMember(3, IsRequired = false, Name = "Ntf", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._Ntf;
			}
			set
			{
				this._Ntf = value;
			}
		}

		// Token: 0x06006777 RID: 26487 RVA: 0x001CC798 File Offset: 0x001CA998
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006778 RID: 26488 RVA: 0x001CC7A8 File Offset: 0x001CA9A8
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

		// Token: 0x06006779 RID: 26489 RVA: 0x001CC874 File Offset: 0x001CAA74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetMissionRewardAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D7C RID: 19836
		private int _Result;

		// Token: 0x04004D7D RID: 19837
		private int _MissionId;

		// Token: 0x04004D7E RID: 19838
		private ProChangedGoodsNtf _Ntf;

		// Token: 0x04004D7F RID: 19839
		private IExtension extensionObject;

		// Token: 0x04004D80 RID: 19840
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D81 RID: 19841
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D82 RID: 19842
		private LuaFunction m_ctor_hotfix;
	}
}
