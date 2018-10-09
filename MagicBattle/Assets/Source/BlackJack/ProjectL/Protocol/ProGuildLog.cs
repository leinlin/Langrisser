using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006AA RID: 1706
	[ProtoContract(Name = "ProGuildLog")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProGuildLog : IExtensible
	{
		// Token: 0x06005C89 RID: 23689 RVA: 0x001A5E58 File Offset: 0x001A4058
		public ProGuildLog()
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

		// Token: 0x1700177A RID: 6010
		// (get) Token: 0x06005C8A RID: 23690 RVA: 0x001A5EC0 File Offset: 0x001A40C0
		// (set) Token: 0x06005C8B RID: 23691 RVA: 0x001A5EC8 File Offset: 0x001A40C8
		[ProtoMember(1, IsRequired = true, Name = "GuildLogModeId", DataFormat = DataFormat.TwosComplement)]
		public int GuildLogModeId
		{
			get
			{
				return this._GuildLogModeId;
			}
			set
			{
				this._GuildLogModeId = value;
			}
		}

		// Token: 0x1700177B RID: 6011
		// (get) Token: 0x06005C8C RID: 23692 RVA: 0x001A5ED4 File Offset: 0x001A40D4
		// (set) Token: 0x06005C8D RID: 23693 RVA: 0x001A5EDC File Offset: 0x001A40DC
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

		// Token: 0x1700177C RID: 6012
		// (get) Token: 0x06005C8E RID: 23694 RVA: 0x001A5EE8 File Offset: 0x001A40E8
		// (set) Token: 0x06005C8F RID: 23695 RVA: 0x001A5EF0 File Offset: 0x001A40F0
		[ProtoMember(3, IsRequired = true, Name = "SendTime", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005C90 RID: 23696 RVA: 0x001A5EFC File Offset: 0x001A40FC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C91 RID: 23697 RVA: 0x001A5F0C File Offset: 0x001A410C
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

		// Token: 0x06005C92 RID: 23698 RVA: 0x001A5FD8 File Offset: 0x001A41D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuildLog));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004538 RID: 17720
		private int _GuildLogModeId;

		// Token: 0x04004539 RID: 17721
		private string _Content;

		// Token: 0x0400453A RID: 17722
		private long _SendTime;

		// Token: 0x0400453B RID: 17723
		private IExtension extensionObject;

		// Token: 0x0400453C RID: 17724
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400453D RID: 17725
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400453E RID: 17726
		private LuaFunction m_ctor_hotfix;
	}
}
