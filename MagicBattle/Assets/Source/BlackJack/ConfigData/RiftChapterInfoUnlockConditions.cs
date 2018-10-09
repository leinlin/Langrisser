using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ConfigData
{
	// Token: 0x0200030E RID: 782
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RiftChapterInfoUnlockConditions")]
	[Serializable]
	public class RiftChapterInfoUnlockConditions : IExtensible
	{
		// Token: 0x06002EB7 RID: 11959 RVA: 0x000BA690 File Offset: 0x000B8890
		public RiftChapterInfoUnlockConditions()
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

		// Token: 0x17000D26 RID: 3366
		// (get) Token: 0x06002EB8 RID: 11960 RVA: 0x000BA6F8 File Offset: 0x000B88F8
		// (set) Token: 0x06002EB9 RID: 11961 RVA: 0x000BA700 File Offset: 0x000B8900
		[ProtoMember(1, IsRequired = true, Name = "ConditionType", DataFormat = DataFormat.TwosComplement)]
		public RiftChapterUnlockConditionType ConditionType
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

		// Token: 0x17000D27 RID: 3367
		// (get) Token: 0x06002EBA RID: 11962 RVA: 0x000BA70C File Offset: 0x000B890C
		// (set) Token: 0x06002EBB RID: 11963 RVA: 0x000BA714 File Offset: 0x000B8914
		[ProtoMember(2, IsRequired = true, Name = "Param", DataFormat = DataFormat.TwosComplement)]
		public int Param
		{
			get
			{
				return this._Param;
			}
			set
			{
				this._Param = value;
			}
		}

		// Token: 0x06002EBC RID: 11964 RVA: 0x000BA720 File Offset: 0x000B8920
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06002EBD RID: 11965 RVA: 0x000BA730 File Offset: 0x000B8930
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

		// Token: 0x06002EBE RID: 11966 RVA: 0x000BA7FC File Offset: 0x000B89FC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RiftChapterInfoUnlockConditions));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040023D0 RID: 9168
		private RiftChapterUnlockConditionType _ConditionType;

		// Token: 0x040023D1 RID: 9169
		private int _Param;

		// Token: 0x040023D2 RID: 9170
		private IExtension extensionObject;

		// Token: 0x040023D3 RID: 9171
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040023D4 RID: 9172
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040023D5 RID: 9173
		private LuaFunction m_ctor_hotfix;
	}
}
