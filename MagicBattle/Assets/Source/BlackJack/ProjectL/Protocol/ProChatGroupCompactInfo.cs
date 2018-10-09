using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000683 RID: 1667
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProChatGroupCompactInfo")]
	[Serializable]
	public class ProChatGroupCompactInfo : IExtensible
	{
		// Token: 0x06005AD5 RID: 23253 RVA: 0x001A1144 File Offset: 0x0019F344
		public ProChatGroupCompactInfo()
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

		// Token: 0x170016E1 RID: 5857
		// (get) Token: 0x06005AD6 RID: 23254 RVA: 0x001A11AC File Offset: 0x0019F3AC
		// (set) Token: 0x06005AD7 RID: 23255 RVA: 0x001A11B4 File Offset: 0x0019F3B4
		[ProtoMember(1, IsRequired = true, Name = "ChatGroupId", DataFormat = DataFormat.Default)]
		public string ChatGroupId
		{
			get
			{
				return this._ChatGroupId;
			}
			set
			{
				this._ChatGroupId = value;
			}
		}

		// Token: 0x170016E2 RID: 5858
		// (get) Token: 0x06005AD8 RID: 23256 RVA: 0x001A11C0 File Offset: 0x0019F3C0
		// (set) Token: 0x06005AD9 RID: 23257 RVA: 0x001A11C8 File Offset: 0x0019F3C8
		[ProtoMember(2, IsRequired = true, Name = "Owner", DataFormat = DataFormat.Default)]
		public ProChatUserCompactInfo Owner
		{
			get
			{
				return this._Owner;
			}
			set
			{
				this._Owner = value;
			}
		}

		// Token: 0x170016E3 RID: 5859
		// (get) Token: 0x06005ADA RID: 23258 RVA: 0x001A11D4 File Offset: 0x0019F3D4
		// (set) Token: 0x06005ADB RID: 23259 RVA: 0x001A11DC File Offset: 0x0019F3DC
		[ProtoMember(3, IsRequired = true, Name = "ChatGroupName", DataFormat = DataFormat.Default)]
		public string ChatGroupName
		{
			get
			{
				return this._ChatGroupName;
			}
			set
			{
				this._ChatGroupName = value;
			}
		}

		// Token: 0x170016E4 RID: 5860
		// (get) Token: 0x06005ADC RID: 23260 RVA: 0x001A11E8 File Offset: 0x0019F3E8
		// (set) Token: 0x06005ADD RID: 23261 RVA: 0x001A11F0 File Offset: 0x0019F3F0
		[ProtoMember(4, IsRequired = true, Name = "UserCount", DataFormat = DataFormat.TwosComplement)]
		public int UserCount
		{
			get
			{
				return this._UserCount;
			}
			set
			{
				this._UserCount = value;
			}
		}

		// Token: 0x170016E5 RID: 5861
		// (get) Token: 0x06005ADE RID: 23262 RVA: 0x001A11FC File Offset: 0x0019F3FC
		// (set) Token: 0x06005ADF RID: 23263 RVA: 0x001A1204 File Offset: 0x0019F404
		[ProtoMember(5, IsRequired = true, Name = "OnlineUserCount", DataFormat = DataFormat.TwosComplement)]
		public int OnlineUserCount
		{
			get
			{
				return this._OnlineUserCount;
			}
			set
			{
				this._OnlineUserCount = value;
			}
		}

		// Token: 0x06005AE0 RID: 23264 RVA: 0x001A1210 File Offset: 0x0019F410
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005AE1 RID: 23265 RVA: 0x001A1220 File Offset: 0x0019F420
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

		// Token: 0x06005AE2 RID: 23266 RVA: 0x001A12EC File Offset: 0x0019F4EC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProChatGroupCompactInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004403 RID: 17411
		private string _ChatGroupId;

		// Token: 0x04004404 RID: 17412
		private ProChatUserCompactInfo _Owner;

		// Token: 0x04004405 RID: 17413
		private string _ChatGroupName;

		// Token: 0x04004406 RID: 17414
		private int _UserCount;

		// Token: 0x04004407 RID: 17415
		private int _OnlineUserCount;

		// Token: 0x04004408 RID: 17416
		private IExtension extensionObject;

		// Token: 0x04004409 RID: 17417
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400440A RID: 17418
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400440B RID: 17419
		private LuaFunction m_ctor_hotfix;
	}
}
