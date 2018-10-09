using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006A4 RID: 1700
	[ProtoContract(Name = "ProGuildMember")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProGuildMember : IExtensible
	{
		// Token: 0x06005C26 RID: 23590 RVA: 0x001A5134 File Offset: 0x001A3334
		public ProGuildMember()
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

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06005C27 RID: 23591 RVA: 0x001A519C File Offset: 0x001A339C
		// (set) Token: 0x06005C28 RID: 23592 RVA: 0x001A51A4 File Offset: 0x001A33A4
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

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06005C29 RID: 23593 RVA: 0x001A51B0 File Offset: 0x001A33B0
		// (set) Token: 0x06005C2A RID: 23594 RVA: 0x001A51B8 File Offset: 0x001A33B8
		[ProtoMember(2, IsRequired = true, Name = "Level", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06005C2B RID: 23595 RVA: 0x001A51C4 File Offset: 0x001A33C4
		// (set) Token: 0x06005C2C RID: 23596 RVA: 0x001A51CC File Offset: 0x001A33CC
		[ProtoMember(3, IsRequired = true, Name = "Title", DataFormat = DataFormat.TwosComplement)]
		public int Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				this._Title = value;
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06005C2D RID: 23597 RVA: 0x001A51D8 File Offset: 0x001A33D8
		// (set) Token: 0x06005C2E RID: 23598 RVA: 0x001A51E0 File Offset: 0x001A33E0
		[ProtoMember(4, IsRequired = true, Name = "TotalActivities", DataFormat = DataFormat.TwosComplement)]
		public int TotalActivities
		{
			get
			{
				return this._TotalActivities;
			}
			set
			{
				this._TotalActivities = value;
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06005C2F RID: 23599 RVA: 0x001A51EC File Offset: 0x001A33EC
		// (set) Token: 0x06005C30 RID: 23600 RVA: 0x001A51F4 File Offset: 0x001A33F4
		[ProtoMember(5, IsRequired = true, Name = "Online", DataFormat = DataFormat.Default)]
		public bool Online
		{
			get
			{
				return this._Online;
			}
			set
			{
				this._Online = value;
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06005C31 RID: 23601 RVA: 0x001A5200 File Offset: 0x001A3400
		// (set) Token: 0x06005C32 RID: 23602 RVA: 0x001A5208 File Offset: 0x001A3408
		[ProtoMember(6, IsRequired = true, Name = "LogoutTime", DataFormat = DataFormat.TwosComplement)]
		public long LogoutTime
		{
			get
			{
				return this._LogoutTime;
			}
			set
			{
				this._LogoutTime = value;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06005C33 RID: 23603 RVA: 0x001A5214 File Offset: 0x001A3414
		// (set) Token: 0x06005C34 RID: 23604 RVA: 0x001A521C File Offset: 0x001A341C
		[ProtoMember(7, IsRequired = true, Name = "TopHeroBattlePower", DataFormat = DataFormat.TwosComplement)]
		public int TopHeroBattlePower
		{
			get
			{
				return this._TopHeroBattlePower;
			}
			set
			{
				this._TopHeroBattlePower = value;
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06005C35 RID: 23605 RVA: 0x001A5228 File Offset: 0x001A3428
		// (set) Token: 0x06005C36 RID: 23606 RVA: 0x001A5230 File Offset: 0x001A3430
		[ProtoMember(8, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
		public string UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				this._UserId = value;
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06005C37 RID: 23607 RVA: 0x001A523C File Offset: 0x001A343C
		// (set) Token: 0x06005C38 RID: 23608 RVA: 0x001A5244 File Offset: 0x001A3444
		[ProtoMember(9, IsRequired = true, Name = "HeadIcon", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x1700175B RID: 5979
		// (get) Token: 0x06005C39 RID: 23609 RVA: 0x001A5250 File Offset: 0x001A3450
		// (set) Token: 0x06005C3A RID: 23610 RVA: 0x001A5258 File Offset: 0x001A3458
		[ProtoMember(10, IsRequired = true, Name = "ThisWeekActivities", DataFormat = DataFormat.TwosComplement)]
		public int ThisWeekActivities
		{
			get
			{
				return this._ThisWeekActivities;
			}
			set
			{
				this._ThisWeekActivities = value;
			}
		}

		// Token: 0x06005C3B RID: 23611 RVA: 0x001A5264 File Offset: 0x001A3464
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005C3C RID: 23612 RVA: 0x001A5274 File Offset: 0x001A3474
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

		// Token: 0x06005C3D RID: 23613 RVA: 0x001A5340 File Offset: 0x001A3540
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuildMember));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040044F8 RID: 17656
		private string _Name;

		// Token: 0x040044F9 RID: 17657
		private int _Level;

		// Token: 0x040044FA RID: 17658
		private int _Title;

		// Token: 0x040044FB RID: 17659
		private int _TotalActivities;

		// Token: 0x040044FC RID: 17660
		private bool _Online;

		// Token: 0x040044FD RID: 17661
		private long _LogoutTime;

		// Token: 0x040044FE RID: 17662
		private int _TopHeroBattlePower;

		// Token: 0x040044FF RID: 17663
		private string _UserId;

		// Token: 0x04004500 RID: 17664
		private int _HeadIcon;

		// Token: 0x04004501 RID: 17665
		private int _ThisWeekActivities;

		// Token: 0x04004502 RID: 17666
		private IExtension extensionObject;

		// Token: 0x04004503 RID: 17667
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004504 RID: 17668
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004505 RID: 17669
		private LuaFunction m_ctor_hotfix;
	}
}
