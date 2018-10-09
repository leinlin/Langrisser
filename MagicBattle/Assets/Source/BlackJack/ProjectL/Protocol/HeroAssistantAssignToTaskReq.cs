using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000793 RID: 1939
	[ProtoContract(Name = "HeroAssistantAssignToTaskReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class HeroAssistantAssignToTaskReq : IExtensible
	{
		// Token: 0x060063E9 RID: 25577 RVA: 0x001C0CB4 File Offset: 0x001BEEB4
		public HeroAssistantAssignToTaskReq()
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

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x060063EA RID: 25578 RVA: 0x001C0D28 File Offset: 0x001BEF28
		// (set) Token: 0x060063EB RID: 25579 RVA: 0x001C0D30 File Offset: 0x001BEF30
		[ProtoMember(1, IsRequired = true, Name = "TaskId", DataFormat = DataFormat.TwosComplement)]
		public int TaskId
		{
			get
			{
				return this._TaskId;
			}
			set
			{
				this._TaskId = value;
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x060063EC RID: 25580 RVA: 0x001C0D3C File Offset: 0x001BEF3C
		// (set) Token: 0x060063ED RID: 25581 RVA: 0x001C0D44 File Offset: 0x001BEF44
		[ProtoMember(2, IsRequired = true, Name = "Slot", DataFormat = DataFormat.TwosComplement)]
		public int Slot
		{
			get
			{
				return this._Slot;
			}
			set
			{
				this._Slot = value;
			}
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x060063EE RID: 25582 RVA: 0x001C0D50 File Offset: 0x001BEF50
		[ProtoMember(3, Name = "HeroIds", DataFormat = DataFormat.TwosComplement)]
		public List<int> HeroIds
		{
			get
			{
				return this._HeroIds;
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x060063EF RID: 25583 RVA: 0x001C0D58 File Offset: 0x001BEF58
		// (set) Token: 0x060063F0 RID: 25584 RVA: 0x001C0D60 File Offset: 0x001BEF60
		[ProtoMember(4, IsRequired = true, Name = "WorkSeconds", DataFormat = DataFormat.TwosComplement)]
		public int WorkSeconds
		{
			get
			{
				return this._WorkSeconds;
			}
			set
			{
				this._WorkSeconds = value;
			}
		}

		// Token: 0x060063F1 RID: 25585 RVA: 0x001C0D6C File Offset: 0x001BEF6C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060063F2 RID: 25586 RVA: 0x001C0D7C File Offset: 0x001BEF7C
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

		// Token: 0x060063F3 RID: 25587 RVA: 0x001C0E48 File Offset: 0x001BF048
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroAssistantAssignToTaskReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004AE6 RID: 19174
		private int _TaskId;

		// Token: 0x04004AE7 RID: 19175
		private int _Slot;

		// Token: 0x04004AE8 RID: 19176
		private readonly List<int> _HeroIds = new List<int>();

		// Token: 0x04004AE9 RID: 19177
		private int _WorkSeconds;

		// Token: 0x04004AEA RID: 19178
		private IExtension extensionObject;

		// Token: 0x04004AEB RID: 19179
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AEC RID: 19180
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AED RID: 19181
		private LuaFunction m_ctor_hotfix;
	}
}
