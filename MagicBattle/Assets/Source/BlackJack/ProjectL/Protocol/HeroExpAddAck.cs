using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007B2 RID: 1970
	[ProtoContract(Name = "HeroExpAddAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroExpAddAck : IExtensible
	{
		// Token: 0x06006507 RID: 25863 RVA: 0x001C4748 File Offset: 0x001C2948
		public HeroExpAddAck()
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

		// Token: 0x170019DB RID: 6619
		// (get) Token: 0x06006508 RID: 25864 RVA: 0x001C47B0 File Offset: 0x001C29B0
		// (set) Token: 0x06006509 RID: 25865 RVA: 0x001C47B8 File Offset: 0x001C29B8
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

		// Token: 0x170019DC RID: 6620
		// (get) Token: 0x0600650A RID: 25866 RVA: 0x001C47C4 File Offset: 0x001C29C4
		// (set) Token: 0x0600650B RID: 25867 RVA: 0x001C47CC File Offset: 0x001C29CC
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

		// Token: 0x170019DD RID: 6621
		// (get) Token: 0x0600650C RID: 25868 RVA: 0x001C47D8 File Offset: 0x001C29D8
		// (set) Token: 0x0600650D RID: 25869 RVA: 0x001C47E0 File Offset: 0x001C29E0
		[ProtoMember(3, IsRequired = true, Name = "GoodsTypeId", DataFormat = DataFormat.TwosComplement)]
		public int GoodsTypeId
		{
			get
			{
				return this._GoodsTypeId;
			}
			set
			{
				this._GoodsTypeId = value;
			}
		}

		// Token: 0x170019DE RID: 6622
		// (get) Token: 0x0600650E RID: 25870 RVA: 0x001C47EC File Offset: 0x001C29EC
		// (set) Token: 0x0600650F RID: 25871 RVA: 0x001C47F4 File Offset: 0x001C29F4
		[ProtoMember(4, IsRequired = true, Name = "ContentId", DataFormat = DataFormat.TwosComplement)]
		public int ContentId
		{
			get
			{
				return this._ContentId;
			}
			set
			{
				this._ContentId = value;
			}
		}

		// Token: 0x170019DF RID: 6623
		// (get) Token: 0x06006510 RID: 25872 RVA: 0x001C4800 File Offset: 0x001C2A00
		// (set) Token: 0x06006511 RID: 25873 RVA: 0x001C4808 File Offset: 0x001C2A08
		[ProtoMember(5, IsRequired = true, Name = "Nums", DataFormat = DataFormat.TwosComplement)]
		public int Nums
		{
			get
			{
				return this._Nums;
			}
			set
			{
				this._Nums = value;
			}
		}

		// Token: 0x170019E0 RID: 6624
		// (get) Token: 0x06006512 RID: 25874 RVA: 0x001C4814 File Offset: 0x001C2A14
		// (set) Token: 0x06006513 RID: 25875 RVA: 0x001C481C File Offset: 0x001C2A1C
		[ProtoMember(6, IsRequired = true, Name = "ReqNums", DataFormat = DataFormat.TwosComplement)]
		public int ReqNums
		{
			get
			{
				return this._ReqNums;
			}
			set
			{
				this._ReqNums = value;
			}
		}

		// Token: 0x06006514 RID: 25876 RVA: 0x001C4828 File Offset: 0x001C2A28
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006515 RID: 25877 RVA: 0x001C4838 File Offset: 0x001C2A38
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

		// Token: 0x06006516 RID: 25878 RVA: 0x001C4904 File Offset: 0x001C2B04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroExpAddAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004BB9 RID: 19385
		private int _Result;

		// Token: 0x04004BBA RID: 19386
		private int _HeroId;

		// Token: 0x04004BBB RID: 19387
		private int _GoodsTypeId;

		// Token: 0x04004BBC RID: 19388
		private int _ContentId;

		// Token: 0x04004BBD RID: 19389
		private int _Nums;

		// Token: 0x04004BBE RID: 19390
		private int _ReqNums;

		// Token: 0x04004BBF RID: 19391
		private IExtension extensionObject;

		// Token: 0x04004BC0 RID: 19392
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004BC1 RID: 19393
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004BC2 RID: 19394
		private LuaFunction m_ctor_hotfix;
	}
}
