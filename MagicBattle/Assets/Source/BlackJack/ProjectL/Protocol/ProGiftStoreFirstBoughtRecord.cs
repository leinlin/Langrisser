using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000698 RID: 1688
	[ProtoContract(Name = "ProGiftStoreFirstBoughtRecord")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProGiftStoreFirstBoughtRecord : IExtensible
	{
		// Token: 0x06005BA1 RID: 23457 RVA: 0x001A3994 File Offset: 0x001A1B94
		public ProGiftStoreFirstBoughtRecord()
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

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x06005BA2 RID: 23458 RVA: 0x001A39FC File Offset: 0x001A1BFC
		// (set) Token: 0x06005BA3 RID: 23459 RVA: 0x001A3A04 File Offset: 0x001A1C04
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

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x06005BA4 RID: 23460 RVA: 0x001A3A10 File Offset: 0x001A1C10
		// (set) Token: 0x06005BA5 RID: 23461 RVA: 0x001A3A18 File Offset: 0x001A1C18
		[ProtoMember(2, IsRequired = true, Name = "GoodsRegisterId", DataFormat = DataFormat.Default)]
		public string GoodsRegisterId
		{
			get
			{
				return this._GoodsRegisterId;
			}
			set
			{
				this._GoodsRegisterId = value;
			}
		}

		// Token: 0x06005BA6 RID: 23462 RVA: 0x001A3A24 File Offset: 0x001A1C24
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005BA7 RID: 23463 RVA: 0x001A3A34 File Offset: 0x001A1C34
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

		// Token: 0x06005BA8 RID: 23464 RVA: 0x001A3B00 File Offset: 0x001A1D00
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGiftStoreFirstBoughtRecord));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400449A RID: 17562
		private int _GoodsId;

		// Token: 0x0400449B RID: 17563
		private string _GoodsRegisterId;

		// Token: 0x0400449C RID: 17564
		private IExtension extensionObject;

		// Token: 0x0400449D RID: 17565
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400449E RID: 17566
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400449F RID: 17567
		private LuaFunction m_ctor_hotfix;
	}
}
