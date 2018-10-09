using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200030F RID: 783
	[ProtoContract(Name = "RiftLevelInfoUnlockConditions")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RiftLevelInfoUnlockConditions : IExtensible
	{
		// Token: 0x06002EBF RID: 11967 RVA: 0x000BA864 File Offset: 0x000B8A64
		public RiftLevelInfoUnlockConditions()
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

		// Token: 0x17000D28 RID: 3368
		// (get) Token: 0x06002EC0 RID: 11968 RVA: 0x000BA8CC File Offset: 0x000B8ACC
		// (set) Token: 0x06002EC1 RID: 11969 RVA: 0x000BA8D4 File Offset: 0x000B8AD4
		[ProtoMember(1, IsRequired = true, Name = "ConditionType", DataFormat = DataFormat.TwosComplement)]
		public RiftLevelUnlockConditionType ConditionType
		{
			get
			{
				return this._ConditionType;
			}
			set
			{
				this._ConditionType = value;
			}
		}

		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x06002EC2 RID: 11970 RVA: 0x000BA8E0 File Offset: 0x000B8AE0
		// (set) Token: 0x06002EC3 RID: 11971 RVA: 0x000BA8E8 File Offset: 0x000B8AE8
		[ProtoMember(2, IsRequired = true, Name = "Param1", DataFormat = DataFormat.TwosComplement)]
		public int Param1
		{
			get
			{
				return this._Param1;
			}
			set
			{
				this._Param1 = value;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x06002EC4 RID: 11972 RVA: 0x000BA8F4 File Offset: 0x000B8AF4
		// (set) Token: 0x06002EC5 RID: 11973 RVA: 0x000BA8FC File Offset: 0x000B8AFC
		[ProtoMember(3, IsRequired = true, Name = "Param2", DataFormat = DataFormat.TwosComplement)]
		public int Param2
		{
			get
			{
				return this._Param2;
			}
			set
			{
				this._Param2 = value;
			}
		}

		// Token: 0x06002EC6 RID: 11974 RVA: 0x000BA908 File Offset: 0x000B8B08
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002EC7 RID: 11975 RVA: 0x000BA918 File Offset: 0x000B8B18
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

		// Token: 0x06002EC8 RID: 11976 RVA: 0x000BA9E4 File Offset: 0x000B8BE4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftLevelInfoUnlockConditions));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023D6 RID: 9174
		private RiftLevelUnlockConditionType _ConditionType;

		// Token: 0x040023D7 RID: 9175
		private int _Param1;

		// Token: 0x040023D8 RID: 9176
		private int _Param2;

		// Token: 0x040023D9 RID: 9177
		private IExtension extensionObject;

		// Token: 0x040023DA RID: 9178
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023DB RID: 9179
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023DC RID: 9180
		private LuaFunction m_ctor_hotfix;
	}
}
