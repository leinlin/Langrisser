using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000321 RID: 801
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RandomBoxGoods")]
	[Serializable]
	public class RandomBoxGoods : IExtensible
	{
		// Token: 0x06002F65 RID: 12133 RVA: 0x000BCA28 File Offset: 0x000BAC28
		public RandomBoxGoods()
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

		// Token: 0x17000D57 RID: 3415
		// (get) Token: 0x06002F66 RID: 12134 RVA: 0x000BCA90 File Offset: 0x000BAC90
		// (set) Token: 0x06002F67 RID: 12135 RVA: 0x000BCA98 File Offset: 0x000BAC98
		[ProtoMember(1, IsRequired = true, Name = "GoodsType", DataFormat = DataFormat.TwosComplement)]
		public GoodsType GoodsType
		{
			get
			{
				return this._GoodsType;
			}
			set
			{
				this._GoodsType = value;
			}
		}

		// Token: 0x17000D58 RID: 3416
		// (get) Token: 0x06002F68 RID: 12136 RVA: 0x000BCAA4 File Offset: 0x000BACA4
		// (set) Token: 0x06002F69 RID: 12137 RVA: 0x000BCAAC File Offset: 0x000BACAC
		[ProtoMember(2, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				this._Id = value;
			}
		}

		// Token: 0x17000D59 RID: 3417
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x000BCAB8 File Offset: 0x000BACB8
		// (set) Token: 0x06002F6B RID: 12139 RVA: 0x000BCAC0 File Offset: 0x000BACC0
		[ProtoMember(3, IsRequired = true, Name = "MinNums", DataFormat = DataFormat.TwosComplement)]
		public int MinNums
		{
			get
			{
				return this._MinNums;
			}
			set
			{
				this._MinNums = value;
			}
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002F6C RID: 12140 RVA: 0x000BCACC File Offset: 0x000BACCC
		// (set) Token: 0x06002F6D RID: 12141 RVA: 0x000BCAD4 File Offset: 0x000BACD4
		[ProtoMember(4, IsRequired = true, Name = "MaxNums", DataFormat = DataFormat.TwosComplement)]
		public int MaxNums
		{
			get
			{
				return this._MaxNums;
			}
			set
			{
				this._MaxNums = value;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002F6E RID: 12142 RVA: 0x000BCAE0 File Offset: 0x000BACE0
		// (set) Token: 0x06002F6F RID: 12143 RVA: 0x000BCAE8 File Offset: 0x000BACE8
		[ProtoMember(5, IsRequired = true, Name = "Weight", DataFormat = DataFormat.TwosComplement)]
		public int Weight
		{
			get
			{
				return this._Weight;
			}
			set
			{
				this._Weight = value;
			}
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x000BCAF4 File Offset: 0x000BACF4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x000BCB04 File Offset: 0x000BAD04
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

		// Token: 0x06002F72 RID: 12146 RVA: 0x000BCBD0 File Offset: 0x000BADD0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RandomBoxGoods));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400244D RID: 9293
		private GoodsType _GoodsType;

		// Token: 0x0400244E RID: 9294
		private int _Id;

		// Token: 0x0400244F RID: 9295
		private int _MinNums;

		// Token: 0x04002450 RID: 9296
		private int _MaxNums;

		// Token: 0x04002451 RID: 9297
		private int _Weight;

		// Token: 0x04002452 RID: 9298
		private IExtension extensionObject;

		// Token: 0x04002453 RID: 9299
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002454 RID: 9300
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002455 RID: 9301
		private LuaFunction m_ctor_hotfix;
	}
}
