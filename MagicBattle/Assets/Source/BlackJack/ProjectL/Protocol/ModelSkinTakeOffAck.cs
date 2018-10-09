using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007CE RID: 1998
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ModelSkinTakeOffAck")]
	[Serializable]
	public class ModelSkinTakeOffAck : IExtensible
	{
		// Token: 0x06006610 RID: 26128 RVA: 0x001C7C1C File Offset: 0x001C5E1C
		public ModelSkinTakeOffAck()
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

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x06006611 RID: 26129 RVA: 0x001C7C84 File Offset: 0x001C5E84
		// (set) Token: 0x06006612 RID: 26130 RVA: 0x001C7C8C File Offset: 0x001C5E8C
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

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x06006613 RID: 26131 RVA: 0x001C7C98 File Offset: 0x001C5E98
		// (set) Token: 0x06006614 RID: 26132 RVA: 0x001C7CA0 File Offset: 0x001C5EA0
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

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x06006615 RID: 26133 RVA: 0x001C7CAC File Offset: 0x001C5EAC
		// (set) Token: 0x06006616 RID: 26134 RVA: 0x001C7CB4 File Offset: 0x001C5EB4
		[ProtoMember(3, IsRequired = true, Name = "JobRelatedId", DataFormat = DataFormat.TwosComplement)]
		public int JobRelatedId
		{
			get
			{
				return this._JobRelatedId;
			}
			set
			{
				this._JobRelatedId = value;
			}
		}

		// Token: 0x06006617 RID: 26135 RVA: 0x001C7CC0 File Offset: 0x001C5EC0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006618 RID: 26136 RVA: 0x001C7CD0 File Offset: 0x001C5ED0
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

		// Token: 0x06006619 RID: 26137 RVA: 0x001C7D9C File Offset: 0x001C5F9C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ModelSkinTakeOffAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C76 RID: 19574
		private int _Result;

		// Token: 0x04004C77 RID: 19575
		private int _HeroId;

		// Token: 0x04004C78 RID: 19576
		private int _JobRelatedId;

		// Token: 0x04004C79 RID: 19577
		private IExtension extensionObject;

		// Token: 0x04004C7A RID: 19578
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C7B RID: 19579
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004C7C RID: 19580
		private LuaFunction m_ctor_hotfix;
	}
}
