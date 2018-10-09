using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000733 RID: 1843
	[ProtoContract(Name = "DSHeroPhantomNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSHeroPhantomNtf : IExtensible
	{
		// Token: 0x06006121 RID: 24865 RVA: 0x001B5EBC File Offset: 0x001B40BC
		public DSHeroPhantomNtf()
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

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x06006122 RID: 24866 RVA: 0x001B5F30 File Offset: 0x001B4130
		// (set) Token: 0x06006123 RID: 24867 RVA: 0x001B5F38 File Offset: 0x001B4138
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

		// Token: 0x170018DA RID: 6362
		// (get) Token: 0x06006124 RID: 24868 RVA: 0x001B5F44 File Offset: 0x001B4144
		[ProtoMember(2, Name = "HeroPhantoms", DataFormat = DataFormat.Default)]
		public List<ProHeroPhantom> HeroPhantoms
		{
			get
			{
				return this._HeroPhantoms;
			}
		}

		// Token: 0x06006125 RID: 24869 RVA: 0x001B5F4C File Offset: 0x001B414C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006126 RID: 24870 RVA: 0x001B5F5C File Offset: 0x001B415C
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

		// Token: 0x06006127 RID: 24871 RVA: 0x001B6028 File Offset: 0x001B4228
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSHeroPhantomNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048BB RID: 18619
		private uint _Version;

		// Token: 0x040048BC RID: 18620
		private readonly List<ProHeroPhantom> _HeroPhantoms = new List<ProHeroPhantom>();

		// Token: 0x040048BD RID: 18621
		private IExtension extensionObject;

		// Token: 0x040048BE RID: 18622
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048BF RID: 18623
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048C0 RID: 18624
		private LuaFunction m_ctor_hotfix;
	}
}
