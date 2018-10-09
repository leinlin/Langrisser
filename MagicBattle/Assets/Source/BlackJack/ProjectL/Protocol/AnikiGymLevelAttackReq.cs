using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005AE RID: 1454
	[ProtoContract(Name = "AnikiGymLevelAttackReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class AnikiGymLevelAttackReq : IExtensible
	{
		// Token: 0x0600528D RID: 21133 RVA: 0x00187758 File Offset: 0x00185958
		public AnikiGymLevelAttackReq()
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

		// Token: 0x17001434 RID: 5172
		// (get) Token: 0x0600528E RID: 21134 RVA: 0x001877C0 File Offset: 0x001859C0
		// (set) Token: 0x0600528F RID: 21135 RVA: 0x001877C8 File Offset: 0x001859C8
		[ProtoMember(1, IsRequired = true, Name = "LevelId", DataFormat = DataFormat.TwosComplement)]
		public int LevelId
		{
			get
			{
				return this._LevelId;
			}
			set
			{
				this._LevelId = value;
			}
		}

		// Token: 0x06005290 RID: 21136 RVA: 0x001877D4 File Offset: 0x001859D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005291 RID: 21137 RVA: 0x001877E4 File Offset: 0x001859E4
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

		// Token: 0x06005292 RID: 21138 RVA: 0x001878B0 File Offset: 0x00185AB0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AnikiGymLevelAttackReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E02 RID: 15874
		private int _LevelId;

		// Token: 0x04003E03 RID: 15875
		private IExtension extensionObject;

		// Token: 0x04003E04 RID: 15876
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E05 RID: 15877
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E06 RID: 15878
		private LuaFunction m_ctor_hotfix;
	}
}
