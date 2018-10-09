using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006AF RID: 1711
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ProGuildMassiveCombatMemberInfo")]
	[Serializable]
	public class ProGuildMassiveCombatMemberInfo : IExtensible
	{
		// Token: 0x06005CB9 RID: 23737 RVA: 0x001A67E0 File Offset: 0x001A49E0
		public ProGuildMassiveCombatMemberInfo()
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

		// Token: 0x17001789 RID: 6025
		// (get) Token: 0x06005CBA RID: 23738 RVA: 0x001A6848 File Offset: 0x001A4A48
		// (set) Token: 0x06005CBB RID: 23739 RVA: 0x001A6850 File Offset: 0x001A4A50
		[ProtoMember(1, IsRequired = true, Name = "UserId", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700178A RID: 6026
		// (get) Token: 0x06005CBC RID: 23740 RVA: 0x001A685C File Offset: 0x001A4A5C
		// (set) Token: 0x06005CBD RID: 23741 RVA: 0x001A6864 File Offset: 0x001A4A64
		[ProtoMember(3, IsRequired = true, Name = "Points", DataFormat = DataFormat.TwosComplement)]
		public int Points
		{
			get
			{
				return this._Points;
			}
			set
			{
				this._Points = value;
			}
		}

		// Token: 0x1700178B RID: 6027
		// (get) Token: 0x06005CBE RID: 23742 RVA: 0x001A6870 File Offset: 0x001A4A70
		// (set) Token: 0x06005CBF RID: 23743 RVA: 0x001A6878 File Offset: 0x001A4A78
		[ProtoMember(4, IsRequired = true, Name = "PointsToday", DataFormat = DataFormat.TwosComplement)]
		public int PointsToday
		{
			get
			{
				return this._PointsToday;
			}
			set
			{
				this._PointsToday = value;
			}
		}

		// Token: 0x1700178C RID: 6028
		// (get) Token: 0x06005CC0 RID: 23744 RVA: 0x001A6884 File Offset: 0x001A4A84
		// (set) Token: 0x06005CC1 RID: 23745 RVA: 0x001A688C File Offset: 0x001A4A8C
		[ProtoMember(5, IsRequired = true, Name = "Title", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x06005CC2 RID: 23746 RVA: 0x001A6898 File Offset: 0x001A4A98
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005CC3 RID: 23747 RVA: 0x001A68A8 File Offset: 0x001A4AA8
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

		// Token: 0x06005CC4 RID: 23748 RVA: 0x001A6974 File Offset: 0x001A4B74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProGuildMassiveCombatMemberInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400455B RID: 17755
		private string _UserId;

		// Token: 0x0400455C RID: 17756
		private int _Points;

		// Token: 0x0400455D RID: 17757
		private int _PointsToday;

		// Token: 0x0400455E RID: 17758
		private int _Title;

		// Token: 0x0400455F RID: 17759
		private IExtension extensionObject;

		// Token: 0x04004560 RID: 17760
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004561 RID: 17761
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004562 RID: 17762
		private LuaFunction m_ctor_hotfix;
	}
}
