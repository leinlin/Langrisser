using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200032E RID: 814
	[ProtoContract(Name = "GDBStargateInfo")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GDBStargateInfo : IExtensible
	{
		// Token: 0x06003068 RID: 12392 RVA: 0x000BE8DC File Offset: 0x000BCADC
		public GDBStargateInfo()
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

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06003069 RID: 12393 RVA: 0x000BE944 File Offset: 0x000BCB44
		// (set) Token: 0x0600306A RID: 12394 RVA: 0x000BE94C File Offset: 0x000BCB4C
		[ProtoMember(1, IsRequired = true, Name = "Id", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x0600306B RID: 12395 RVA: 0x000BE958 File Offset: 0x000BCB58
		// (set) Token: 0x0600306C RID: 12396 RVA: 0x000BE960 File Offset: 0x000BCB60
		[ProtoMember(2, IsRequired = true, Name = "ConfTempleteId", DataFormat = DataFormat.TwosComplement)]
		public int ConfTempleteId
		{
			get
			{
				return this._ConfTempleteId;
			}
			set
			{
				this._ConfTempleteId = value;
			}
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x0600306D RID: 12397 RVA: 0x000BE96C File Offset: 0x000BCB6C
		// (set) Token: 0x0600306E RID: 12398 RVA: 0x000BE974 File Offset: 0x000BCB74
		[ProtoMember(3, IsRequired = true, Name = "locationX", DataFormat = DataFormat.TwosComplement)]
		public double LocationX
		{
			get
			{
				return this._locationX;
			}
			set
			{
				this._locationX = value;
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x0600306F RID: 12399 RVA: 0x000BE980 File Offset: 0x000BCB80
		// (set) Token: 0x06003070 RID: 12400 RVA: 0x000BE988 File Offset: 0x000BCB88
		[ProtoMember(4, IsRequired = true, Name = "locationZ", DataFormat = DataFormat.TwosComplement)]
		public double LocationZ
		{
			get
			{
				return this._locationZ;
			}
			set
			{
				this._locationZ = value;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x06003071 RID: 12401 RVA: 0x000BE994 File Offset: 0x000BCB94
		// (set) Token: 0x06003072 RID: 12402 RVA: 0x000BE99C File Offset: 0x000BCB9C
		[ProtoMember(5, IsRequired = true, Name = "rotationX", DataFormat = DataFormat.TwosComplement)]
		public uint RotationX
		{
			get
			{
				return this._rotationX;
			}
			set
			{
				this._rotationX = value;
			}
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x06003073 RID: 12403 RVA: 0x000BE9A8 File Offset: 0x000BCBA8
		// (set) Token: 0x06003074 RID: 12404 RVA: 0x000BE9B0 File Offset: 0x000BCBB0
		[ProtoMember(6, IsRequired = true, Name = "rotationY", DataFormat = DataFormat.TwosComplement)]
		public uint RotationY
		{
			get
			{
				return this._rotationY;
			}
			set
			{
				this._rotationY = value;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x000BE9BC File Offset: 0x000BCBBC
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x000BE9C4 File Offset: 0x000BCBC4
		[ProtoMember(7, IsRequired = true, Name = "destSolarSystemId", DataFormat = DataFormat.TwosComplement)]
		public int DestSolarSystemId
		{
			get
			{
				return this._destSolarSystemId;
			}
			set
			{
				this._destSolarSystemId = value;
			}
		}

		// Token: 0x06003077 RID: 12407 RVA: 0x000BE9D0 File Offset: 0x000BCBD0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06003078 RID: 12408 RVA: 0x000BE9E0 File Offset: 0x000BCBE0
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

		// Token: 0x06003079 RID: 12409 RVA: 0x000BEAAC File Offset: 0x000BCCAC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBStargateInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040024EE RID: 9454
		private int _Id;

		// Token: 0x040024EF RID: 9455
		private int _ConfTempleteId;

		// Token: 0x040024F0 RID: 9456
		private double _locationX;

		// Token: 0x040024F1 RID: 9457
		private double _locationZ;

		// Token: 0x040024F2 RID: 9458
		private uint _rotationX;

		// Token: 0x040024F3 RID: 9459
		private uint _rotationY;

		// Token: 0x040024F4 RID: 9460
		private int _destSolarSystemId;

		// Token: 0x040024F5 RID: 9461
		private IExtension extensionObject;

		// Token: 0x040024F6 RID: 9462
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040024F7 RID: 9463
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040024F8 RID: 9464
		private LuaFunction m_ctor_hotfix;
	}
}
