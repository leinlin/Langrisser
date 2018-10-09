using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200064F RID: 1615
	[ProtoContract(Name = "ProRandomEvent")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ProRandomEvent : IExtensible
	{
		// Token: 0x06005836 RID: 22582 RVA: 0x0019A6B0 File Offset: 0x001988B0
		public ProRandomEvent()
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

		// Token: 0x170015E6 RID: 5606
		// (get) Token: 0x06005837 RID: 22583 RVA: 0x0019A718 File Offset: 0x00198918
		// (set) Token: 0x06005838 RID: 22584 RVA: 0x0019A720 File Offset: 0x00198920
		[ProtoMember(1, IsRequired = true, Name = "EventId", DataFormat = DataFormat.TwosComplement)]
		public int EventId
		{
			get
			{
				return this._EventId;
			}
			set
			{
				this._EventId = value;
			}
		}

		// Token: 0x170015E7 RID: 5607
		// (get) Token: 0x06005839 RID: 22585 RVA: 0x0019A72C File Offset: 0x0019892C
		// (set) Token: 0x0600583A RID: 22586 RVA: 0x0019A734 File Offset: 0x00198934
		[ProtoMember(2, IsRequired = true, Name = "WayPointId", DataFormat = DataFormat.TwosComplement)]
		public int WayPointId
		{
			get
			{
				return this._WayPointId;
			}
			set
			{
				this._WayPointId = value;
			}
		}

		// Token: 0x170015E8 RID: 5608
		// (get) Token: 0x0600583B RID: 22587 RVA: 0x0019A740 File Offset: 0x00198940
		// (set) Token: 0x0600583C RID: 22588 RVA: 0x0019A748 File Offset: 0x00198948
		[ProtoMember(3, IsRequired = true, Name = "DeadLives", DataFormat = DataFormat.TwosComplement)]
		public int DeadLives
		{
			get
			{
				return this._DeadLives;
			}
			set
			{
				this._DeadLives = value;
			}
		}

		// Token: 0x170015E9 RID: 5609
		// (get) Token: 0x0600583D RID: 22589 RVA: 0x0019A754 File Offset: 0x00198954
		// (set) Token: 0x0600583E RID: 22590 RVA: 0x0019A75C File Offset: 0x0019895C
		[ProtoMember(4, IsRequired = true, Name = "ExpiredTime", DataFormat = DataFormat.TwosComplement)]
		public long ExpiredTime
		{
			get
			{
				return this._ExpiredTime;
			}
			set
			{
				this._ExpiredTime = value;
			}
		}

		// Token: 0x0600583F RID: 22591 RVA: 0x0019A768 File Offset: 0x00198968
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005840 RID: 22592 RVA: 0x0019A778 File Offset: 0x00198978
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

		// Token: 0x06005841 RID: 22593 RVA: 0x0019A844 File Offset: 0x00198A44
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProRandomEvent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004238 RID: 16952
		private int _EventId;

		// Token: 0x04004239 RID: 16953
		private int _WayPointId;

		// Token: 0x0400423A RID: 16954
		private int _DeadLives;

		// Token: 0x0400423B RID: 16955
		private long _ExpiredTime;

		// Token: 0x0400423C RID: 16956
		private IExtension extensionObject;

		// Token: 0x0400423D RID: 16957
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400423E RID: 16958
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400423F RID: 16959
		private LuaFunction m_ctor_hotfix;
	}
}
