using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200073B RID: 1851
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSGuildNtf")]
	[Serializable]
	public class DSGuildNtf : IExtensible
	{
		// Token: 0x0600615C RID: 24924 RVA: 0x001B6D58 File Offset: 0x001B4F58
		public DSGuildNtf()
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

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x0600615D RID: 24925 RVA: 0x001B6DC0 File Offset: 0x001B4FC0
		// (set) Token: 0x0600615E RID: 24926 RVA: 0x001B6DC8 File Offset: 0x001B4FC8
		[ProtoMember(1, IsRequired = true, Name = "Version", DataFormat = DataFormat.TwosComplement)]
		public uint Version
		{
			get
			{
				return this._Version;
			}
			set
			{
				this._Version = value;
			}
		}

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x0600615F RID: 24927 RVA: 0x001B6DD4 File Offset: 0x001B4FD4
		// (set) Token: 0x06006160 RID: 24928 RVA: 0x001B6DDC File Offset: 0x001B4FDC
		[ProtoMember(2, IsRequired = true, Name = "GuildId", DataFormat = DataFormat.Default)]
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

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06006161 RID: 24929 RVA: 0x001B6DE8 File Offset: 0x001B4FE8
		// (set) Token: 0x06006162 RID: 24930 RVA: 0x001B6DF0 File Offset: 0x001B4FF0
		[ProtoMember(3, IsRequired = true, Name = "NextJoinTime", DataFormat = DataFormat.TwosComplement)]
		public long NextJoinTime
		{
			get
			{
				return this._NextJoinTime;
			}
			set
			{
				this._NextJoinTime = value;
			}
		}

		// Token: 0x06006163 RID: 24931 RVA: 0x001B6DFC File Offset: 0x001B4FFC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006164 RID: 24932 RVA: 0x001B6E0C File Offset: 0x001B500C
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

		// Token: 0x06006165 RID: 24933 RVA: 0x001B6ED8 File Offset: 0x001B50D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSGuildNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048EB RID: 18667
		private uint _Version;

		// Token: 0x040048EC RID: 18668
		private string _GuildId;

		// Token: 0x040048ED RID: 18669
		private long _NextJoinTime;

		// Token: 0x040048EE RID: 18670
		private IExtension extensionObject;

		// Token: 0x040048EF RID: 18671
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048F0 RID: 18672
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048F1 RID: 18673
		private LuaFunction m_ctor_hotfix;
	}
}
