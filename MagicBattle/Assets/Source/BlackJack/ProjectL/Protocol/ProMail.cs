using System;
using System.Collections.Generic;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200064C RID: 1612
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProMail")]
	[Serializable]
	public class ProMail : IExtensible
	{
		// Token: 0x06005808 RID: 22536 RVA: 0x0019A030 File Offset: 0x00198230
		public ProMail()
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

		// Token: 0x170015D4 RID: 5588
		// (get) Token: 0x06005809 RID: 22537 RVA: 0x0019A0B8 File Offset: 0x001982B8
		// (set) Token: 0x0600580A RID: 22538 RVA: 0x0019A0C0 File Offset: 0x001982C0
		[ProtoMember(1, IsRequired = true, Name = "TemplateId", DataFormat = DataFormat.TwosComplement)]
		public int TemplateId
		{
			get
			{
				return this._TemplateId;
			}
			set
			{
				this._TemplateId = value;
			}
		}

		// Token: 0x170015D5 RID: 5589
		// (get) Token: 0x0600580B RID: 22539 RVA: 0x0019A0CC File Offset: 0x001982CC
		// (set) Token: 0x0600580C RID: 22540 RVA: 0x0019A0D4 File Offset: 0x001982D4
		[ProtoMember(2, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x170015D6 RID: 5590
		// (get) Token: 0x0600580D RID: 22541 RVA: 0x0019A0E0 File Offset: 0x001982E0
		// (set) Token: 0x0600580E RID: 22542 RVA: 0x0019A0E8 File Offset: 0x001982E8
		[ProtoMember(3, IsRequired = true, Name = "Status", DataFormat = DataFormat.TwosComplement)]
		public int Status
		{
			get
			{
				return this._Status;
			}
			set
			{
				this._Status = value;
			}
		}

		// Token: 0x170015D7 RID: 5591
		// (get) Token: 0x0600580F RID: 22543 RVA: 0x0019A0F4 File Offset: 0x001982F4
		// (set) Token: 0x06005810 RID: 22544 RVA: 0x0019A0FC File Offset: 0x001982FC
		[ProtoMember(4, IsRequired = true, Name = "SendTime", DataFormat = DataFormat.TwosComplement)]
		public long SendTime
		{
			get
			{
				return this._SendTime;
			}
			set
			{
				this._SendTime = value;
			}
		}

		// Token: 0x170015D8 RID: 5592
		// (get) Token: 0x06005811 RID: 22545 RVA: 0x0019A108 File Offset: 0x00198308
		// (set) Token: 0x06005812 RID: 22546 RVA: 0x0019A110 File Offset: 0x00198310
		[ProtoMember(5, IsRequired = true, Name = "ReadedOrGotAttachmentTime", DataFormat = DataFormat.TwosComplement)]
		public long ReadedOrGotAttachmentTime
		{
			get
			{
				return this._ReadedOrGotAttachmentTime;
			}
			set
			{
				this._ReadedOrGotAttachmentTime = value;
			}
		}

		// Token: 0x170015D9 RID: 5593
		// (get) Token: 0x06005813 RID: 22547 RVA: 0x0019A11C File Offset: 0x0019831C
		// (set) Token: 0x06005814 RID: 22548 RVA: 0x0019A124 File Offset: 0x00198324
		[DefaultValue("")]
		[ProtoMember(6, IsRequired = false, Name = "Title", DataFormat = DataFormat.Default)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				this._Title = value;
			}
		}

		// Token: 0x170015DA RID: 5594
		// (get) Token: 0x06005815 RID: 22549 RVA: 0x0019A130 File Offset: 0x00198330
		// (set) Token: 0x06005816 RID: 22550 RVA: 0x0019A138 File Offset: 0x00198338
		[ProtoMember(7, IsRequired = false, Name = "Content", DataFormat = DataFormat.Default)]
		[DefaultValue("")]
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

		// Token: 0x170015DB RID: 5595
		// (get) Token: 0x06005817 RID: 22551 RVA: 0x0019A144 File Offset: 0x00198344
		[ProtoMember(8, Name = "Attachments", DataFormat = DataFormat.Default)]
		public List<ProGoods> Attachments
		{
			get
			{
				return this._Attachments;
			}
		}

		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06005818 RID: 22552 RVA: 0x0019A14C File Offset: 0x0019834C
		// (set) Token: 0x06005819 RID: 22553 RVA: 0x0019A154 File Offset: 0x00198354
		[ProtoMember(9, IsRequired = false, Name = "ExpiredTime", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0L)]
		public uint ExpiredTime
		{
			get
			{
				return this._ExpiredTime;
			}
			set
			{
				this._ExpiredTime = value;
			}
		}

		// Token: 0x170015DD RID: 5597
		// (get) Token: 0x0600581A RID: 22554 RVA: 0x0019A160 File Offset: 0x00198360
		// (set) Token: 0x0600581B RID: 22555 RVA: 0x0019A168 File Offset: 0x00198368
		[DefaultValue(0)]
		[ProtoMember(10, IsRequired = false, Name = "ReadedExpiredTime", DataFormat = DataFormat.TwosComplement)]
		public int ReadedExpiredTime
		{
			get
			{
				return this._ReadedExpiredTime;
			}
			set
			{
				this._ReadedExpiredTime = value;
			}
		}

		// Token: 0x170015DE RID: 5598
		// (get) Token: 0x0600581C RID: 22556 RVA: 0x0019A174 File Offset: 0x00198374
		// (set) Token: 0x0600581D RID: 22557 RVA: 0x0019A17C File Offset: 0x0019837C
		[DefaultValue(false)]
		[ProtoMember(11, IsRequired = false, Name = "GotDeleted", DataFormat = DataFormat.Default)]
		public bool GotDeleted
		{
			get
			{
				return this._GotDeleted;
			}
			set
			{
				this._GotDeleted = value;
			}
		}

		// Token: 0x170015DF RID: 5599
		// (get) Token: 0x0600581E RID: 22558 RVA: 0x0019A188 File Offset: 0x00198388
		// (set) Token: 0x0600581F RID: 22559 RVA: 0x0019A190 File Offset: 0x00198390
		[ProtoMember(12, IsRequired = true, Name = "MailTypeId", DataFormat = DataFormat.TwosComplement)]
		public int MailTypeId
		{
			get
			{
				return this._MailTypeId;
			}
			set
			{
				this._MailTypeId = value;
			}
		}

		// Token: 0x06005820 RID: 22560 RVA: 0x0019A19C File Offset: 0x0019839C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005821 RID: 22561 RVA: 0x0019A1AC File Offset: 0x001983AC
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

		// Token: 0x06005822 RID: 22562 RVA: 0x0019A278 File Offset: 0x00198478
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProMail));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400421A RID: 16922
		private int _TemplateId;

		// Token: 0x0400421B RID: 16923
		private ulong _InstanceId;

		// Token: 0x0400421C RID: 16924
		private int _Status;

		// Token: 0x0400421D RID: 16925
		private long _SendTime;

		// Token: 0x0400421E RID: 16926
		private long _ReadedOrGotAttachmentTime;

		// Token: 0x0400421F RID: 16927
		private string _Title = string.Empty;

		// Token: 0x04004220 RID: 16928
		private string _Content = string.Empty;

		// Token: 0x04004221 RID: 16929
		private readonly List<ProGoods> _Attachments = new List<ProGoods>();

		// Token: 0x04004222 RID: 16930
		private uint _ExpiredTime;

		// Token: 0x04004223 RID: 16931
		private int _ReadedExpiredTime;

		// Token: 0x04004224 RID: 16932
		private bool _GotDeleted;

		// Token: 0x04004225 RID: 16933
		private int _MailTypeId;

		// Token: 0x04004226 RID: 16934
		private IExtension extensionObject;

		// Token: 0x04004227 RID: 16935
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004228 RID: 16936
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004229 RID: 16937
		private LuaFunction m_ctor_hotfix;
	}
}
