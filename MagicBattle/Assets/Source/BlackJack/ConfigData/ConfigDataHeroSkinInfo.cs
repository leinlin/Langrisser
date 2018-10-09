using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x02000251 RID: 593
	[HotFix(true, m_isCtorOnly = true)]
	[CustomLuaClass]
	[ProtoContract(Name = "ConfigDataHeroSkinInfo")]
	[Serializable]
	public class ConfigDataHeroSkinInfo : IExtensible
	{
		// Token: 0x0600250D RID: 9485 RVA: 0x000A837C File Offset: 0x000A657C
		public ConfigDataHeroSkinInfo()
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

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x0600250E RID: 9486 RVA: 0x000A83F8 File Offset: 0x000A65F8
		// (set) Token: 0x0600250F RID: 9487 RVA: 0x000A8400 File Offset: 0x000A6600
		[ProtoMember(2, IsRequired = true, Name = "ID", DataFormat = DataFormat.TwosComplement)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				this._ID = value;
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06002510 RID: 9488 RVA: 0x000A840C File Offset: 0x000A660C
		// (set) Token: 0x06002511 RID: 9489 RVA: 0x000A8414 File Offset: 0x000A6614
		[ProtoMember(3, IsRequired = true, Name = "Name", DataFormat = DataFormat.Default)]
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

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06002512 RID: 9490 RVA: 0x000A8420 File Offset: 0x000A6620
		// (set) Token: 0x06002513 RID: 9491 RVA: 0x000A8428 File Offset: 0x000A6628
		[ProtoMember(4, IsRequired = true, Name = "SpecifiedHero", DataFormat = DataFormat.TwosComplement)]
		public int SpecifiedHero
		{
			get
			{
				return this._SpecifiedHero;
			}
			set
			{
				this._SpecifiedHero = value;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06002514 RID: 9492 RVA: 0x000A8434 File Offset: 0x000A6634
		// (set) Token: 0x06002515 RID: 9493 RVA: 0x000A843C File Offset: 0x000A663C
		[ProtoMember(5, IsRequired = true, Name = "CharImageSkinResource_ID", DataFormat = DataFormat.TwosComplement)]
		public int CharImageSkinResource_ID
		{
			get
			{
				return this._CharImageSkinResource_ID;
			}
			set
			{
				this._CharImageSkinResource_ID = value;
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06002516 RID: 9494 RVA: 0x000A8448 File Offset: 0x000A6648
		[ProtoMember(6, Name = "SpecifiedModelSkinResource", DataFormat = DataFormat.Default)]
		public List<JobConnection2SkinResource> SpecifiedModelSkinResource
		{
			get
			{
				return this._SpecifiedModelSkinResource;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06002517 RID: 9495 RVA: 0x000A8450 File Offset: 0x000A6650
		// (set) Token: 0x06002518 RID: 9496 RVA: 0x000A8458 File Offset: 0x000A6658
		[ProtoMember(7, IsRequired = true, Name = "Desc", DataFormat = DataFormat.Default)]
		public string Desc
		{
			get
			{
				return this._Desc;
			}
			set
			{
				this._Desc = value;
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06002519 RID: 9497 RVA: 0x000A8464 File Offset: 0x000A6664
		// (set) Token: 0x0600251A RID: 9498 RVA: 0x000A846C File Offset: 0x000A666C
		[ProtoMember(8, IsRequired = true, Name = "Icon", DataFormat = DataFormat.Default)]
		public string Icon
		{
			get
			{
				return this._Icon;
			}
			set
			{
				this._Icon = value;
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x0600251B RID: 9499 RVA: 0x000A8478 File Offset: 0x000A6678
		[ProtoMember(9, Name = "GetPathList", DataFormat = DataFormat.Default)]
		public List<GetPathData> GetPathList
		{
			get
			{
				return this._GetPathList;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x0600251C RID: 9500 RVA: 0x000A8480 File Offset: 0x000A6680
		// (set) Token: 0x0600251D RID: 9501 RVA: 0x000A8488 File Offset: 0x000A6688
		[ProtoMember(10, IsRequired = true, Name = "GetPathDesc", DataFormat = DataFormat.Default)]
		public string GetPathDesc
		{
			get
			{
				return this._GetPathDesc;
			}
			set
			{
				this._GetPathDesc = value;
			}
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000A8494 File Offset: 0x000A6694
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000A84A4 File Offset: 0x000A66A4
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

		// Token: 0x06002520 RID: 9504 RVA: 0x000A8570 File Offset: 0x000A6770
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ConfigDataHeroSkinInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040016A1 RID: 5793
		private int _ID;

		// Token: 0x040016A2 RID: 5794
		private string _Name;

		// Token: 0x040016A3 RID: 5795
		private int _SpecifiedHero;

		// Token: 0x040016A4 RID: 5796
		private int _CharImageSkinResource_ID;

		// Token: 0x040016A5 RID: 5797
		private readonly List<JobConnection2SkinResource> _SpecifiedModelSkinResource = new List<JobConnection2SkinResource>();

		// Token: 0x040016A6 RID: 5798
		private string _Desc;

		// Token: 0x040016A7 RID: 5799
		private string _Icon;

		// Token: 0x040016A8 RID: 5800
		private readonly List<GetPathData> _GetPathList = new List<GetPathData>();

		// Token: 0x040016A9 RID: 5801
		private string _GetPathDesc;

		// Token: 0x040016AA RID: 5802
		private IExtension extensionObject;

		// Token: 0x040016AB RID: 5803
		public int FixedStoreItemId;

		// Token: 0x040016AC RID: 5804
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040016AD RID: 5805
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040016AE RID: 5806
		private LuaFunction m_ctor_hotfix;
	}
}
