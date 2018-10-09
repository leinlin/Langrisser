using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000697 RID: 1687
	[ProtoContract(Name = "ProGiftStoreItem")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProGiftStoreItem : IExtensible
	{
		// Token: 0x06005B97 RID: 23447 RVA: 0x001A37AC File Offset: 0x001A19AC
		public ProGiftStoreItem()
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

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x06005B98 RID: 23448 RVA: 0x001A3814 File Offset: 0x001A1A14
		// (set) Token: 0x06005B99 RID: 23449 RVA: 0x001A381C File Offset: 0x001A1A1C
		[ProtoMember(1, IsRequired = true, Name = "GoodsId", DataFormat = DataFormat.TwosComplement)]
		public int GoodsId
		{
			get
			{
				return this._GoodsId;
			}
			set
			{
				this._GoodsId = value;
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x06005B9A RID: 23450 RVA: 0x001A3828 File Offset: 0x001A1A28
		// (set) Token: 0x06005B9B RID: 23451 RVA: 0x001A3830 File Offset: 0x001A1A30
		[ProtoMember(2, IsRequired = true, Name = "NextFlushTime", DataFormat = DataFormat.TwosComplement)]
		public long NextFlushTime
		{
			get
			{
				return this._NextFlushTime;
			}
			set
			{
				this._NextFlushTime = value;
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x06005B9C RID: 23452 RVA: 0x001A383C File Offset: 0x001A1A3C
		// (set) Token: 0x06005B9D RID: 23453 RVA: 0x001A3844 File Offset: 0x001A1A44
		[ProtoMember(3, IsRequired = true, Name = "BoughtNums", DataFormat = DataFormat.TwosComplement)]
		public int BoughtNums
		{
			get
			{
				return this._BoughtNums;
			}
			set
			{
				this._BoughtNums = value;
			}
		}

		// Token: 0x06005B9E RID: 23454 RVA: 0x001A3850 File Offset: 0x001A1A50
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B9F RID: 23455 RVA: 0x001A3860 File Offset: 0x001A1A60
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

		// Token: 0x06005BA0 RID: 23456 RVA: 0x001A392C File Offset: 0x001A1B2C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGiftStoreItem));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004493 RID: 17555
		private int _GoodsId;

		// Token: 0x04004494 RID: 17556
		private long _NextFlushTime;

		// Token: 0x04004495 RID: 17557
		private int _BoughtNums;

		// Token: 0x04004496 RID: 17558
		private IExtension extensionObject;

		// Token: 0x04004497 RID: 17559
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004498 RID: 17560
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004499 RID: 17561
		private LuaFunction m_ctor_hotfix;
	}
}
