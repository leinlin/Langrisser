using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007D2 RID: 2002
	[ProtoContract(Name = "SoldierSkinTakeOffAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class SoldierSkinTakeOffAck : IExtensible
	{
		// Token: 0x0600663E RID: 26174 RVA: 0x001C83F8 File Offset: 0x001C65F8
		public SoldierSkinTakeOffAck()
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

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x0600663F RID: 26175 RVA: 0x001C8460 File Offset: 0x001C6660
		// (set) Token: 0x06006640 RID: 26176 RVA: 0x001C8468 File Offset: 0x001C6668
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

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x06006641 RID: 26177 RVA: 0x001C8474 File Offset: 0x001C6674
		// (set) Token: 0x06006642 RID: 26178 RVA: 0x001C847C File Offset: 0x001C667C
		[ProtoMember(2, IsRequired = true, Name = "HeroId", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x06006643 RID: 26179 RVA: 0x001C8488 File Offset: 0x001C6688
		// (set) Token: 0x06006644 RID: 26180 RVA: 0x001C8490 File Offset: 0x001C6690
		[ProtoMember(3, IsRequired = true, Name = "SoldierId", DataFormat = DataFormat.TwosComplement)]
		public int SoldierId
		{
			get
			{
				return this._SoldierId;
			}
			set
			{
				this._SoldierId = value;
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x06006645 RID: 26181 RVA: 0x001C849C File Offset: 0x001C669C
		// (set) Token: 0x06006646 RID: 26182 RVA: 0x001C84A4 File Offset: 0x001C66A4
		[ProtoMember(4, IsRequired = true, Name = "All", DataFormat = DataFormat.Default)]
		public bool All
		{
			get
			{
				return this._All;
			}
			set
			{
				this._All = value;
			}
		}

		// Token: 0x06006647 RID: 26183 RVA: 0x001C84B0 File Offset: 0x001C66B0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006648 RID: 26184 RVA: 0x001C84C0 File Offset: 0x001C66C0
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

		// Token: 0x06006649 RID: 26185 RVA: 0x001C858C File Offset: 0x001C678C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(SoldierSkinTakeOffAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C95 RID: 19605
		private int _Result;

		// Token: 0x04004C96 RID: 19606
		private int _HeroId;

		// Token: 0x04004C97 RID: 19607
		private int _SoldierId;

		// Token: 0x04004C98 RID: 19608
		private bool _All;

		// Token: 0x04004C99 RID: 19609
		private IExtension extensionObject;

		// Token: 0x04004C9A RID: 19610
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C9B RID: 19611
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C9C RID: 19612
		private LuaFunction m_ctor_hotfix;
	}
}
