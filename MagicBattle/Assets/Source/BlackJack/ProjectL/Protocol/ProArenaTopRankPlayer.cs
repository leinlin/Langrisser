using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200065F RID: 1631
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProArenaTopRankPlayer")]
	[Serializable]
	public class ProArenaTopRankPlayer : IExtensible
	{
		// Token: 0x060058F9 RID: 22777 RVA: 0x0019C704 File Offset: 0x0019A904
		public ProArenaTopRankPlayer()
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

		// Token: 0x1700162E RID: 5678
		// (get) Token: 0x060058FA RID: 22778 RVA: 0x0019C76C File Offset: 0x0019A96C
		// (set) Token: 0x060058FB RID: 22779 RVA: 0x0019C774 File Offset: 0x0019A974
		[ProtoMember(1, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700162F RID: 5679
		// (get) Token: 0x060058FC RID: 22780 RVA: 0x0019C780 File Offset: 0x0019A980
		// (set) Token: 0x060058FD RID: 22781 RVA: 0x0019C788 File Offset: 0x0019A988
		[ProtoMember(2, IsRequired = true, Name = "ArenaLevel", DataFormat = DataFormat.TwosComplement)]
		public int ArenaLevel
		{
			get
			{
				return this._ArenaLevel;
			}
			set
			{
				this._ArenaLevel = value;
			}
		}

		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x060058FE RID: 22782 RVA: 0x0019C794 File Offset: 0x0019A994
		// (set) Token: 0x060058FF RID: 22783 RVA: 0x0019C79C File Offset: 0x0019A99C
		[ProtoMember(3, IsRequired = true, Name = "ArenaPoints", DataFormat = DataFormat.TwosComplement)]
		public uint ArenaPoints
		{
			get
			{
				return this._ArenaPoints;
			}
			set
			{
				this._ArenaPoints = value;
			}
		}

		// Token: 0x17001631 RID: 5681
		// (get) Token: 0x06005900 RID: 22784 RVA: 0x0019C7A8 File Offset: 0x0019A9A8
		// (set) Token: 0x06005901 RID: 22785 RVA: 0x0019C7B0 File Offset: 0x0019A9B0
		[ProtoMember(4, IsRequired = true, Name = "HeadIcon", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001632 RID: 5682
		// (get) Token: 0x06005902 RID: 22786 RVA: 0x0019C7BC File Offset: 0x0019A9BC
		// (set) Token: 0x06005903 RID: 22787 RVA: 0x0019C7C4 File Offset: 0x0019A9C4
		[ProtoMember(5, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005904 RID: 22788 RVA: 0x0019C7D0 File Offset: 0x0019A9D0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005905 RID: 22789 RVA: 0x0019C7E0 File Offset: 0x0019A9E0
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

		// Token: 0x06005906 RID: 22790 RVA: 0x0019C8AC File Offset: 0x0019AAAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProArenaTopRankPlayer));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040042C0 RID: 17088
		private string _Name;

		// Token: 0x040042C1 RID: 17089
		private int _ArenaLevel;

		// Token: 0x040042C2 RID: 17090
		private uint _ArenaPoints;

		// Token: 0x040042C3 RID: 17091
		private int _HeadIcon;

		// Token: 0x040042C4 RID: 17092
		private int _Level;

		// Token: 0x040042C5 RID: 17093
		private IExtension extensionObject;

		// Token: 0x040042C6 RID: 17094
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040042C7 RID: 17095
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040042C8 RID: 17096
		private LuaFunction m_ctor_hotfix;
	}
}
