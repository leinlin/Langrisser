using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200067D RID: 1661
	[ProtoContract(Name = "ProBusinessCardHeroSet")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProBusinessCardHeroSet : IExtensible
	{
		// Token: 0x06005A81 RID: 23169 RVA: 0x001A04C0 File Offset: 0x0019E6C0
		public ProBusinessCardHeroSet()
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

		// Token: 0x170016C1 RID: 5825
		// (get) Token: 0x06005A82 RID: 23170 RVA: 0x001A0528 File Offset: 0x0019E728
		// (set) Token: 0x06005A83 RID: 23171 RVA: 0x001A0530 File Offset: 0x0019E730
		[ProtoMember(1, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
		public int HeroId
		{
			get
			{
				return this._HeroId;
			}
			set
			{
				this._HeroId = value;
			}
		}

		// Token: 0x170016C2 RID: 5826
		// (get) Token: 0x06005A84 RID: 23172 RVA: 0x001A053C File Offset: 0x0019E73C
		// (set) Token: 0x06005A85 RID: 23173 RVA: 0x001A0544 File Offset: 0x0019E744
		[ProtoMember(2, IsRequired = true, Name = "Direction", DataFormat = DataFormat.TwosComplement)]
		public int Direction
		{
			get
			{
				return this._Direction;
			}
			set
			{
				this._Direction = value;
			}
		}

		// Token: 0x170016C3 RID: 5827
		// (get) Token: 0x06005A86 RID: 23174 RVA: 0x001A0550 File Offset: 0x0019E750
		// (set) Token: 0x06005A87 RID: 23175 RVA: 0x001A0558 File Offset: 0x0019E758
		[ProtoMember(3, IsRequired = true, Name = "Action", DataFormat = DataFormat.TwosComplement)]
		public int Action
		{
			get
			{
				return this._Action;
			}
			set
			{
				this._Action = value;
			}
		}

		// Token: 0x170016C4 RID: 5828
		// (get) Token: 0x06005A88 RID: 23176 RVA: 0x001A0564 File Offset: 0x0019E764
		// (set) Token: 0x06005A89 RID: 23177 RVA: 0x001A056C File Offset: 0x0019E76C
		[ProtoMember(4, IsRequired = true, Name = "PositionIndex", DataFormat = DataFormat.TwosComplement)]
		public int PositionIndex
		{
			get
			{
				return this._PositionIndex;
			}
			set
			{
				this._PositionIndex = value;
			}
		}

		// Token: 0x06005A8A RID: 23178 RVA: 0x001A0578 File Offset: 0x0019E778
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005A8B RID: 23179 RVA: 0x001A0588 File Offset: 0x0019E788
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

		// Token: 0x06005A8C RID: 23180 RVA: 0x001A0654 File Offset: 0x0019E854
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProBusinessCardHeroSet));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040043CB RID: 17355
		private int _HeroId;

		// Token: 0x040043CC RID: 17356
		private int _Direction;

		// Token: 0x040043CD RID: 17357
		private int _Action;

		// Token: 0x040043CE RID: 17358
		private int _PositionIndex;

		// Token: 0x040043CF RID: 17359
		private IExtension extensionObject;

		// Token: 0x040043D0 RID: 17360
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040043D1 RID: 17361
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040043D2 RID: 17362
		private LuaFunction m_ctor_hotfix;
	}
}
