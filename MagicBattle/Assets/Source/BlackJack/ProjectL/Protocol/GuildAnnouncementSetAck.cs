using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200077C RID: 1916
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildAnnouncementSetAck")]
	[Serializable]
	public class GuildAnnouncementSetAck : IExtensible
	{
		// Token: 0x0600634B RID: 25419 RVA: 0x001BE398 File Offset: 0x001BC598
		public GuildAnnouncementSetAck()
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

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x0600634C RID: 25420 RVA: 0x001BE400 File Offset: 0x001BC600
		// (set) Token: 0x0600634D RID: 25421 RVA: 0x001BE408 File Offset: 0x001BC608
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

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x0600634E RID: 25422 RVA: 0x001BE414 File Offset: 0x001BC614
		// (set) Token: 0x0600634F RID: 25423 RVA: 0x001BE41C File Offset: 0x001BC61C
		[ProtoMember(2, IsRequired = true, Name = "Announcement", DataFormat = DataFormat.Default)]
		public string Announcement
		{
			get
			{
				return this._Announcement;
			}
			set
			{
				this._Announcement = value;
			}
		}

		// Token: 0x06006350 RID: 25424 RVA: 0x001BE428 File Offset: 0x001BC628
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006351 RID: 25425 RVA: 0x001BE438 File Offset: 0x001BC638
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

		// Token: 0x06006352 RID: 25426 RVA: 0x001BE504 File Offset: 0x001BC704
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildAnnouncementSetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A68 RID: 19048
		private int _Result;

		// Token: 0x04004A69 RID: 19049
		private string _Announcement;

		// Token: 0x04004A6A RID: 19050
		private IExtension extensionObject;

		// Token: 0x04004A6B RID: 19051
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004A6C RID: 19052
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004A6D RID: 19053
		private LuaFunction m_ctor_hotfix;
	}
}
