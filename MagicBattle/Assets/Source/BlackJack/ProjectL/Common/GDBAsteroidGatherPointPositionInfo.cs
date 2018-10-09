using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000330 RID: 816
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GDBAsteroidGatherPointPositionInfo")]
	[Serializable]
	public class GDBAsteroidGatherPointPositionInfo : IExtensible
	{
		// Token: 0x06003089 RID: 12425 RVA: 0x000BED4C File Offset: 0x000BCF4C
		public GDBAsteroidGatherPointPositionInfo()
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

		// Token: 0x17000DD1 RID: 3537
		// (get) Token: 0x0600308A RID: 12426 RVA: 0x000BEDB4 File Offset: 0x000BCFB4
		// (set) Token: 0x0600308B RID: 12427 RVA: 0x000BEDBC File Offset: 0x000BCFBC
		[ProtoMember(1, IsRequired = true, Name = "locationX", DataFormat = DataFormat.TwosComplement)]
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

		// Token: 0x17000DD2 RID: 3538
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x000BEDC8 File Offset: 0x000BCFC8
		// (set) Token: 0x0600308D RID: 12429 RVA: 0x000BEDD0 File Offset: 0x000BCFD0
		[ProtoMember(2, IsRequired = true, Name = "locationY", DataFormat = DataFormat.TwosComplement)]
		public double LocationY
		{
			get
			{
				return this._locationY;
			}
			set
			{
				this._locationY = value;
			}
		}

		// Token: 0x0600308E RID: 12430 RVA: 0x000BEDDC File Offset: 0x000BCFDC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600308F RID: 12431 RVA: 0x000BEDEC File Offset: 0x000BCFEC
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

		// Token: 0x06003090 RID: 12432 RVA: 0x000BEEB8 File Offset: 0x000BD0B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GDBAsteroidGatherPointPositionInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002503 RID: 9475
		private double _locationX;

		// Token: 0x04002504 RID: 9476
		private double _locationY;

		// Token: 0x04002505 RID: 9477
		private IExtension extensionObject;

		// Token: 0x04002506 RID: 9478
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002507 RID: 9479
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002508 RID: 9480
		private LuaFunction m_ctor_hotfix;
	}
}
