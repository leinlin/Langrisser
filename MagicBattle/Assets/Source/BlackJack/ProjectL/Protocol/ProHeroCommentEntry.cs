using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000657 RID: 1623
	[ProtoContract(Name = "ProHeroCommentEntry")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProHeroCommentEntry : IExtensible
	{
		// Token: 0x06005886 RID: 22662 RVA: 0x0019B618 File Offset: 0x00199818
		public ProHeroCommentEntry()
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

		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06005887 RID: 22663 RVA: 0x0019B680 File Offset: 0x00199880
		// (set) Token: 0x06005888 RID: 22664 RVA: 0x0019B688 File Offset: 0x00199888
		[ProtoMember(1, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x17001601 RID: 5633
		// (get) Token: 0x06005889 RID: 22665 RVA: 0x0019B694 File Offset: 0x00199894
		// (set) Token: 0x0600588A RID: 22666 RVA: 0x0019B69C File Offset: 0x0019989C
		[ProtoMember(2, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
		public string Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				this._Content = value;
			}
		}

		// Token: 0x17001602 RID: 5634
		// (get) Token: 0x0600588B RID: 22667 RVA: 0x0019B6A8 File Offset: 0x001998A8
		// (set) Token: 0x0600588C RID: 22668 RVA: 0x0019B6B0 File Offset: 0x001998B0
		[ProtoMember(3, IsRequired = true, Name = "CommenterUserId", DataFormat = DataFormat.Default)]
		public string CommenterUserId
		{
			get
			{
				return this._CommenterUserId;
			}
			set
			{
				this._CommenterUserId = value;
			}
		}

		// Token: 0x17001603 RID: 5635
		// (get) Token: 0x0600588D RID: 22669 RVA: 0x0019B6BC File Offset: 0x001998BC
		// (set) Token: 0x0600588E RID: 22670 RVA: 0x0019B6C4 File Offset: 0x001998C4
		[ProtoMember(4, IsRequired = true, Name = "CommenterName", DataFormat = DataFormat.Default)]
		public string CommenterName
		{
			get
			{
				return this._CommenterName;
			}
			set
			{
				this._CommenterName = value;
			}
		}

		// Token: 0x17001604 RID: 5636
		// (get) Token: 0x0600588F RID: 22671 RVA: 0x0019B6D0 File Offset: 0x001998D0
		// (set) Token: 0x06005890 RID: 22672 RVA: 0x0019B6D8 File Offset: 0x001998D8
		[ProtoMember(5, IsRequired = true, Name = "CommenterLevel", DataFormat = DataFormat.TwosComplement)]
		public int CommenterLevel
		{
			get
			{
				return this._CommenterLevel;
			}
			set
			{
				this._CommenterLevel = value;
			}
		}

		// Token: 0x17001605 RID: 5637
		// (get) Token: 0x06005891 RID: 22673 RVA: 0x0019B6E4 File Offset: 0x001998E4
		// (set) Token: 0x06005892 RID: 22674 RVA: 0x0019B6EC File Offset: 0x001998EC
		[ProtoMember(6, IsRequired = true, Name = "PraiseNums", DataFormat = DataFormat.TwosComplement)]
		public int PraiseNums
		{
			get
			{
				return this._PraiseNums;
			}
			set
			{
				this._PraiseNums = value;
			}
		}

		// Token: 0x17001606 RID: 5638
		// (get) Token: 0x06005893 RID: 22675 RVA: 0x0019B6F8 File Offset: 0x001998F8
		// (set) Token: 0x06005894 RID: 22676 RVA: 0x0019B700 File Offset: 0x00199900
		[ProtoMember(7, IsRequired = true, Name = "CommentTime", DataFormat = DataFormat.TwosComplement)]
		public long CommentTime
		{
			get
			{
				return this._CommentTime;
			}
			set
			{
				this._CommentTime = value;
			}
		}

		// Token: 0x06005895 RID: 22677 RVA: 0x0019B70C File Offset: 0x0019990C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005896 RID: 22678 RVA: 0x0019B71C File Offset: 0x0019991C
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

		// Token: 0x06005897 RID: 22679 RVA: 0x0019B7E8 File Offset: 0x001999E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProHeroCommentEntry));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004272 RID: 17010
		private ulong _InstanceId;

		// Token: 0x04004273 RID: 17011
		private string _Content;

		// Token: 0x04004274 RID: 17012
		private string _CommenterUserId;

		// Token: 0x04004275 RID: 17013
		private string _CommenterName;

		// Token: 0x04004276 RID: 17014
		private int _CommenterLevel;

		// Token: 0x04004277 RID: 17015
		private int _PraiseNums;

		// Token: 0x04004278 RID: 17016
		private long _CommentTime;

		// Token: 0x04004279 RID: 17017
		private IExtension extensionObject;

		// Token: 0x0400427A RID: 17018
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400427B RID: 17019
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400427C RID: 17020
		private LuaFunction m_ctor_hotfix;
	}
}
