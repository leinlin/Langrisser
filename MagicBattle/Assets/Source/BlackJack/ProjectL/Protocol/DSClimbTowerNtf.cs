using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200073D RID: 1853
	[ProtoContract(Name = "DSClimbTowerNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class DSClimbTowerNtf : IExtensible
	{
		// Token: 0x0600616D RID: 24941 RVA: 0x001B7114 File Offset: 0x001B5314
		public DSClimbTowerNtf()
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

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x0600616E RID: 24942 RVA: 0x001B717C File Offset: 0x001B537C
		// (set) Token: 0x0600616F RID: 24943 RVA: 0x001B7184 File Offset: 0x001B5384
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

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x06006170 RID: 24944 RVA: 0x001B7190 File Offset: 0x001B5390
		// (set) Token: 0x06006171 RID: 24945 RVA: 0x001B7198 File Offset: 0x001B5398
		[ProtoMember(2, IsRequired = true, Name = "ClimbTower", DataFormat = DataFormat.Default)]
		public ProClimbTower ClimbTower
		{
			get
			{
				return this._ClimbTower;
			}
			set
			{
				this._ClimbTower = value;
			}
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06006172 RID: 24946 RVA: 0x001B71A4 File Offset: 0x001B53A4
		// (set) Token: 0x06006173 RID: 24947 RVA: 0x001B71AC File Offset: 0x001B53AC
		[ProtoMember(3, IsRequired = true, Name = "Floor", DataFormat = DataFormat.TwosComplement)]
		public int Floor
		{
			get
			{
				return this._Floor;
			}
			set
			{
				this._Floor = value;
			}
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06006174 RID: 24948 RVA: 0x001B71B8 File Offset: 0x001B53B8
		// (set) Token: 0x06006175 RID: 24949 RVA: 0x001B71C0 File Offset: 0x001B53C0
		[ProtoMember(4, IsRequired = true, Name = "HistoryFloorMax", DataFormat = DataFormat.TwosComplement)]
		public int HistoryFloorMax
		{
			get
			{
				return this._HistoryFloorMax;
			}
			set
			{
				this._HistoryFloorMax = value;
			}
		}

		// Token: 0x06006176 RID: 24950 RVA: 0x001B71CC File Offset: 0x001B53CC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006177 RID: 24951 RVA: 0x001B71DC File Offset: 0x001B53DC
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

		// Token: 0x06006178 RID: 24952 RVA: 0x001B72A8 File Offset: 0x001B54A8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(DSClimbTowerNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040048F8 RID: 18680
		private uint _Version;

		// Token: 0x040048F9 RID: 18681
		private ProClimbTower _ClimbTower;

		// Token: 0x040048FA RID: 18682
		private int _Floor;

		// Token: 0x040048FB RID: 18683
		private int _HistoryFloorMax;

		// Token: 0x040048FC RID: 18684
		private IExtension extensionObject;

		// Token: 0x040048FD RID: 18685
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040048FE RID: 18686
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040048FF RID: 18687
		private LuaFunction m_ctor_hotfix;
	}
}
