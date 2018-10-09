using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200066A RID: 1642
	[ProtoContract(Name = "ProMarquee")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProMarquee : IExtensible
	{
		// Token: 0x0600599B RID: 22939 RVA: 0x0019DEAC File Offset: 0x0019C0AC
		public ProMarquee()
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

		// Token: 0x17001670 RID: 5744
		// (get) Token: 0x0600599C RID: 22940 RVA: 0x0019DF14 File Offset: 0x0019C114
		// (set) Token: 0x0600599D RID: 22941 RVA: 0x0019DF1C File Offset: 0x0019C11C
		[ProtoMember(1, IsRequired = true, Name = "SendTime", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001671 RID: 5745
		// (get) Token: 0x0600599E RID: 22942 RVA: 0x0019DF28 File Offset: 0x0019C128
		// (set) Token: 0x0600599F RID: 22943 RVA: 0x0019DF30 File Offset: 0x0019C130
		[ProtoMember(2, IsRequired = true, Name = "Title", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001672 RID: 5746
		// (get) Token: 0x060059A0 RID: 22944 RVA: 0x0019DF3C File Offset: 0x0019C13C
		// (set) Token: 0x060059A1 RID: 22945 RVA: 0x0019DF44 File Offset: 0x0019C144
		[ProtoMember(3, IsRequired = true, Name = "Content", DataFormat = DataFormat.Default)]
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

		// Token: 0x060059A2 RID: 22946 RVA: 0x0019DF50 File Offset: 0x0019C150
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x0019DF60 File Offset: 0x0019C160
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

		// Token: 0x060059A4 RID: 22948 RVA: 0x0019E02C File Offset: 0x0019C22C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProMarquee));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400432E RID: 17198
		private long _SendTime;

		// Token: 0x0400432F RID: 17199
		private string _Title;

		// Token: 0x04004330 RID: 17200
		private string _Content;

		// Token: 0x04004331 RID: 17201
		private IExtension extensionObject;

		// Token: 0x04004332 RID: 17202
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004333 RID: 17203
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004334 RID: 17204
		private LuaFunction m_ctor_hotfix;
	}
}
