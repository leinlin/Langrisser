using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200065E RID: 1630
	[ProtoContract(Name = "ProArenaOpponent")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProArenaOpponent : IExtensible
	{
		// Token: 0x060058ED RID: 22765 RVA: 0x0019C508 File Offset: 0x0019A708
		public ProArenaOpponent()
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

		// Token: 0x1700162A RID: 5674
		// (get) Token: 0x060058EE RID: 22766 RVA: 0x0019C570 File Offset: 0x0019A770
		// (set) Token: 0x060058EF RID: 22767 RVA: 0x0019C578 File Offset: 0x0019A778
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

		// Token: 0x1700162B RID: 5675
		// (get) Token: 0x060058F0 RID: 22768 RVA: 0x0019C584 File Offset: 0x0019A784
		// (set) Token: 0x060058F1 RID: 22769 RVA: 0x0019C58C File Offset: 0x0019A78C
		[ProtoMember(2, IsRequired = true, Name = "PlayerLevel", DataFormat = DataFormat.TwosComplement)]
		public int PlayerLevel
		{
			get
			{
				return this._PlayerLevel;
			}
			set
			{
				this._PlayerLevel = value;
			}
		}

		// Token: 0x1700162C RID: 5676
		// (get) Token: 0x060058F2 RID: 22770 RVA: 0x0019C598 File Offset: 0x0019A798
		// (set) Token: 0x060058F3 RID: 22771 RVA: 0x0019C5A0 File Offset: 0x0019A7A0
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

		// Token: 0x1700162D RID: 5677
		// (get) Token: 0x060058F4 RID: 22772 RVA: 0x0019C5AC File Offset: 0x0019A7AC
		// (set) Token: 0x060058F5 RID: 22773 RVA: 0x0019C5B4 File Offset: 0x0019A7B4
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

		// Token: 0x060058F6 RID: 22774 RVA: 0x0019C5C0 File Offset: 0x0019A7C0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060058F7 RID: 22775 RVA: 0x0019C5D0 File Offset: 0x0019A7D0
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

		// Token: 0x060058F8 RID: 22776 RVA: 0x0019C69C File Offset: 0x0019A89C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProArenaOpponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040042B8 RID: 17080
		private string _Name;

		// Token: 0x040042B9 RID: 17081
		private int _PlayerLevel;

		// Token: 0x040042BA RID: 17082
		private uint _ArenaPoints;

		// Token: 0x040042BB RID: 17083
		private int _HeadIcon;

		// Token: 0x040042BC RID: 17084
		private IExtension extensionObject;

		// Token: 0x040042BD RID: 17085
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040042BE RID: 17086
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040042BF RID: 17087
		private LuaFunction m_ctor_hotfix;
	}
}
