using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200062A RID: 1578
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProChatInfo")]
	[Serializable]
	public class ProChatInfo : IExtensible
	{
		// Token: 0x0600569F RID: 22175 RVA: 0x00195DD4 File Offset: 0x00193FD4
		public ProChatInfo()
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

		// Token: 0x1700155B RID: 5467
		// (get) Token: 0x060056A0 RID: 22176 RVA: 0x00195E3C File Offset: 0x0019403C
		// (set) Token: 0x060056A1 RID: 22177 RVA: 0x00195E44 File Offset: 0x00194044
		[ProtoMember(1, IsRequired = true, Name = "ChatSrcType", DataFormat = DataFormat.TwosComplement)]
		public int ChatSrcType
		{
			get
			{
				return this._ChatSrcType;
			}
			set
			{
				this._ChatSrcType = value;
			}
		}

		// Token: 0x1700155C RID: 5468
		// (get) Token: 0x060056A2 RID: 22178 RVA: 0x00195E50 File Offset: 0x00194050
		// (set) Token: 0x060056A3 RID: 22179 RVA: 0x00195E58 File Offset: 0x00194058
		[ProtoMember(2, IsRequired = true, Name = "SrcName", DataFormat = DataFormat.Default)]
		public string SrcName
		{
			get
			{
				return this._SrcName;
			}
			set
			{
				this._SrcName = value;
			}
		}

		// Token: 0x1700155D RID: 5469
		// (get) Token: 0x060056A4 RID: 22180 RVA: 0x00195E64 File Offset: 0x00194064
		// (set) Token: 0x060056A5 RID: 22181 RVA: 0x00195E6C File Offset: 0x0019406C
		[ProtoMember(3, IsRequired = true, Name = "AvatarId", DataFormat = DataFormat.TwosComplement)]
		public int AvatarId
		{
			get
			{
				return this._AvatarId;
			}
			set
			{
				this._AvatarId = value;
			}
		}

		// Token: 0x1700155E RID: 5470
		// (get) Token: 0x060056A6 RID: 22182 RVA: 0x00195E78 File Offset: 0x00194078
		// (set) Token: 0x060056A7 RID: 22183 RVA: 0x00195E80 File Offset: 0x00194080
		[ProtoMember(4, IsRequired = true, Name = "ChatContentType", DataFormat = DataFormat.TwosComplement)]
		public int ChatContentType
		{
			get
			{
				return this._ChatContentType;
			}
			set
			{
				this._ChatContentType = value;
			}
		}

		// Token: 0x1700155F RID: 5471
		// (get) Token: 0x060056A8 RID: 22184 RVA: 0x00195E8C File Offset: 0x0019408C
		// (set) Token: 0x060056A9 RID: 22185 RVA: 0x00195E94 File Offset: 0x00194094
		[ProtoMember(5, IsRequired = true, Name = "SrcPlayerLevel", DataFormat = DataFormat.TwosComplement)]
		public int SrcPlayerLevel
		{
			get
			{
				return this._SrcPlayerLevel;
			}
			set
			{
				this._SrcPlayerLevel = value;
			}
		}

		// Token: 0x17001560 RID: 5472
		// (get) Token: 0x060056AA RID: 22186 RVA: 0x00195EA0 File Offset: 0x001940A0
		// (set) Token: 0x060056AB RID: 22187 RVA: 0x00195EA8 File Offset: 0x001940A8
		[ProtoMember(6, IsRequired = true, Name = "SrcGameUserID", DataFormat = DataFormat.Default)]
		public string SrcGameUserID
		{
			get
			{
				return this._SrcGameUserID;
			}
			set
			{
				this._SrcGameUserID = value;
			}
		}

		// Token: 0x060056AC RID: 22188 RVA: 0x00195EB4 File Offset: 0x001940B4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060056AD RID: 22189 RVA: 0x00195EC4 File Offset: 0x001940C4
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

		// Token: 0x060056AE RID: 22190 RVA: 0x00195F90 File Offset: 0x00194190
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProChatInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004119 RID: 16665
		private int _ChatSrcType;

		// Token: 0x0400411A RID: 16666
		private string _SrcName;

		// Token: 0x0400411B RID: 16667
		private int _AvatarId;

		// Token: 0x0400411C RID: 16668
		private int _ChatContentType;

		// Token: 0x0400411D RID: 16669
		private int _SrcPlayerLevel;

		// Token: 0x0400411E RID: 16670
		private string _SrcGameUserID;

		// Token: 0x0400411F RID: 16671
		private IExtension extensionObject;

		// Token: 0x04004120 RID: 16672
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004121 RID: 16673
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004122 RID: 16674
		private LuaFunction m_ctor_hotfix;
	}
}
