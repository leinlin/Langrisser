using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000669 RID: 1641
	[ProtoContract(Name = "ProAnnouncement")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProAnnouncement : IExtensible
	{
		// Token: 0x0600598D RID: 22925 RVA: 0x0019DC9C File Offset: 0x0019BE9C
		public ProAnnouncement()
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

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x0600598E RID: 22926 RVA: 0x0019DD04 File Offset: 0x0019BF04
		// (set) Token: 0x0600598F RID: 22927 RVA: 0x0019DD0C File Offset: 0x0019BF0C
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

		// Token: 0x1700166C RID: 5740
		// (get) Token: 0x06005990 RID: 22928 RVA: 0x0019DD18 File Offset: 0x0019BF18
		// (set) Token: 0x06005991 RID: 22929 RVA: 0x0019DD20 File Offset: 0x0019BF20
		[ProtoMember(2, IsRequired = true, Name = "ShowStartTime", DataFormat = DataFormat.TwosComplement)]
		public long ShowStartTime
		{
			get
			{
				return this._ShowStartTime;
			}
			set
			{
				this._ShowStartTime = value;
			}
		}

		// Token: 0x1700166D RID: 5741
		// (get) Token: 0x06005992 RID: 22930 RVA: 0x0019DD2C File Offset: 0x0019BF2C
		// (set) Token: 0x06005993 RID: 22931 RVA: 0x0019DD34 File Offset: 0x0019BF34
		[ProtoMember(3, IsRequired = true, Name = "ShowEndTime", DataFormat = DataFormat.TwosComplement)]
		public long ShowEndTime
		{
			get
			{
				return this._ShowEndTime;
			}
			set
			{
				this._ShowEndTime = value;
			}
		}

		// Token: 0x1700166E RID: 5742
		// (get) Token: 0x06005994 RID: 22932 RVA: 0x0019DD40 File Offset: 0x0019BF40
		// (set) Token: 0x06005995 RID: 22933 RVA: 0x0019DD48 File Offset: 0x0019BF48
		[ProtoMember(4, IsRequired = true, Name = "Title", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700166F RID: 5743
		// (get) Token: 0x06005996 RID: 22934 RVA: 0x0019DD54 File Offset: 0x0019BF54
		// (set) Token: 0x06005997 RID: 22935 RVA: 0x0019DD5C File Offset: 0x0019BF5C
		[ProtoMember(5, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
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

		// Token: 0x06005998 RID: 22936 RVA: 0x0019DD68 File Offset: 0x0019BF68
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005999 RID: 22937 RVA: 0x0019DD78 File Offset: 0x0019BF78
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

		// Token: 0x0600599A RID: 22938 RVA: 0x0019DE44 File Offset: 0x0019C044
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProAnnouncement));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004325 RID: 17189
		private ulong _InstanceId;

		// Token: 0x04004326 RID: 17190
		private long _ShowStartTime;

		// Token: 0x04004327 RID: 17191
		private long _ShowEndTime;

		// Token: 0x04004328 RID: 17192
		private string _Title;

		// Token: 0x04004329 RID: 17193
		private string _Content;

		// Token: 0x0400432A RID: 17194
		private IExtension extensionObject;

		// Token: 0x0400432B RID: 17195
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400432C RID: 17196
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400432D RID: 17197
		private LuaFunction m_ctor_hotfix;
	}
}
