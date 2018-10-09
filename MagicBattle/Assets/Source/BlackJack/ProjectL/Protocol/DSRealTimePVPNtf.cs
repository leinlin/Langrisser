using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000737 RID: 1847
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "DSRealTimePVPNtf")]
	[Serializable]
	public class DSRealTimePVPNtf : IExtensible
	{
		// Token: 0x0600613F RID: 24895 RVA: 0x001B660C File Offset: 0x001B480C
		public DSRealTimePVPNtf()
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

		// Token: 0x170018E1 RID: 6369
		// (get) Token: 0x06006140 RID: 24896 RVA: 0x001B6674 File Offset: 0x001B4874
		// (set) Token: 0x06006141 RID: 24897 RVA: 0x001B667C File Offset: 0x001B487C
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

		// Token: 0x170018E2 RID: 6370
		// (get) Token: 0x06006142 RID: 24898 RVA: 0x001B6688 File Offset: 0x001B4888
		// (set) Token: 0x06006143 RID: 24899 RVA: 0x001B6690 File Offset: 0x001B4890
		[ProtoMember(2, IsRequired = true, Name = "RealTimePVP", DataFormat = DataFormat.Default)]
		public ProRealTimePVP RealTimePVP
		{
			get
			{
				return this._RealTimePVP;
			}
			set
			{
				this._RealTimePVP = value;
			}
		}

		// Token: 0x06006144 RID: 24900 RVA: 0x001B669C File Offset: 0x001B489C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006145 RID: 24901 RVA: 0x001B66AC File Offset: 0x001B48AC
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

		// Token: 0x06006146 RID: 24902 RVA: 0x001B6778 File Offset: 0x001B4978
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSRealTimePVPNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048D3 RID: 18643
		private uint _Version;

		// Token: 0x040048D4 RID: 18644
		private ProRealTimePVP _RealTimePVP;

		// Token: 0x040048D5 RID: 18645
		private IExtension extensionObject;

		// Token: 0x040048D6 RID: 18646
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048D7 RID: 18647
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048D8 RID: 18648
		private LuaFunction m_ctor_hotfix;
	}
}
