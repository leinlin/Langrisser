using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006A6 RID: 1702
	[ProtoContract(Name = "ProGuildJoinInvitation")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProGuildJoinInvitation : IExtensible
	{
		// Token: 0x06005C5B RID: 23643 RVA: 0x001A5658 File Offset: 0x001A3858
		public ProGuildJoinInvitation()
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

		// Token: 0x17001769 RID: 5993
		// (get) Token: 0x06005C5C RID: 23644 RVA: 0x001A56C0 File Offset: 0x001A38C0
		// (set) Token: 0x06005C5D RID: 23645 RVA: 0x001A56C8 File Offset: 0x001A38C8
		[ProtoMember(1, IsRequired = true, Name = "GuildId", DataFormat = DataFormat.Default)]
		public string GuildId
		{
			get
			{
				return this._GuildId;
			}
			set
			{
				this._GuildId = value;
			}
		}

		// Token: 0x1700176A RID: 5994
		// (get) Token: 0x06005C5E RID: 23646 RVA: 0x001A56D4 File Offset: 0x001A38D4
		// (set) Token: 0x06005C5F RID: 23647 RVA: 0x001A56DC File Offset: 0x001A38DC
		[ProtoMember(2, IsRequired = true, Name = "GuildName", DataFormat = DataFormat.Default)]
		public string GuildName
		{
			get
			{
				return this._GuildName;
			}
			set
			{
				this._GuildName = value;
			}
		}

		// Token: 0x1700176B RID: 5995
		// (get) Token: 0x06005C60 RID: 23648 RVA: 0x001A56E8 File Offset: 0x001A38E8
		// (set) Token: 0x06005C61 RID: 23649 RVA: 0x001A56F0 File Offset: 0x001A38F0
		[ProtoMember(3, IsRequired = true, Name = "HeadIcon", DataFormat = DataFormat.TwosComplement)]
		public int HeadIcon
		{
			get
			{
				return this._HeadIcon;
			}
			set
			{
				this._HeadIcon = value;
			}
		}

		// Token: 0x1700176C RID: 5996
		// (get) Token: 0x06005C62 RID: 23650 RVA: 0x001A56FC File Offset: 0x001A38FC
		// (set) Token: 0x06005C63 RID: 23651 RVA: 0x001A5704 File Offset: 0x001A3904
		[ProtoMember(4, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				this._Level = value;
			}
		}

		// Token: 0x1700176D RID: 5997
		// (get) Token: 0x06005C64 RID: 23652 RVA: 0x001A5710 File Offset: 0x001A3910
		// (set) Token: 0x06005C65 RID: 23653 RVA: 0x001A5718 File Offset: 0x001A3918
		[ProtoMember(5, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				this._Name = value;
			}
		}

		// Token: 0x06005C66 RID: 23654 RVA: 0x001A5724 File Offset: 0x001A3924
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C67 RID: 23655 RVA: 0x001A5734 File Offset: 0x001A3934
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

		// Token: 0x06005C68 RID: 23656 RVA: 0x001A5800 File Offset: 0x001A3A00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuildJoinInvitation));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004517 RID: 17687
		private string _GuildId;

		// Token: 0x04004518 RID: 17688
		private string _GuildName;

		// Token: 0x04004519 RID: 17689
		private int _HeadIcon;

		// Token: 0x0400451A RID: 17690
		private int _Level;

		// Token: 0x0400451B RID: 17691
		private string _Name;

		// Token: 0x0400451C RID: 17692
		private IExtension extensionObject;

		// Token: 0x0400451D RID: 17693
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400451E RID: 17694
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400451F RID: 17695
		private LuaFunction m_ctor_hotfix;
	}
}
