using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000335 RID: 821
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "PVector3D")]
	[Serializable]
	public class PVector3D : IExtensible
	{
		// Token: 0x060030C9 RID: 12489 RVA: 0x000BF770 File Offset: 0x000BD970
		public PVector3D()
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

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x060030CA RID: 12490 RVA: 0x000BF7D8 File Offset: 0x000BD9D8
		// (set) Token: 0x060030CB RID: 12491 RVA: 0x000BF7E0 File Offset: 0x000BD9E0
		[ProtoMember(1, IsRequired = true, Name = "X", DataFormat = DataFormat.FixedSize)]
		public float X
		{
			get
			{
				return this._X;
			}
			set
			{
				this._X = value;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x060030CC RID: 12492 RVA: 0x000BF7EC File Offset: 0x000BD9EC
		// (set) Token: 0x060030CD RID: 12493 RVA: 0x000BF7F4 File Offset: 0x000BD9F4
		[ProtoMember(2, IsRequired = true, Name = "Y", DataFormat = DataFormat.FixedSize)]
		public float Y
		{
			get
			{
				return this._Y;
			}
			set
			{
				this._Y = value;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x060030CE RID: 12494 RVA: 0x000BF800 File Offset: 0x000BDA00
		// (set) Token: 0x060030CF RID: 12495 RVA: 0x000BF808 File Offset: 0x000BDA08
		[ProtoMember(3, IsRequired = true, Name = "Z", DataFormat = DataFormat.FixedSize)]
		public float Z
		{
			get
			{
				return this._Z;
			}
			set
			{
				this._Z = value;
			}
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x000BF814 File Offset: 0x000BDA14
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x000BF824 File Offset: 0x000BDA24
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

		// Token: 0x060030D2 RID: 12498 RVA: 0x000BF8F0 File Offset: 0x000BDAF0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PVector3D));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400252E RID: 9518
		private float _X;

		// Token: 0x0400252F RID: 9519
		private float _Y;

		// Token: 0x04002530 RID: 9520
		private float _Z;

		// Token: 0x04002531 RID: 9521
		private IExtension extensionObject;

		// Token: 0x04002532 RID: 9522
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002533 RID: 9523
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002534 RID: 9524
		private LuaFunction m_ctor_hotfix;
	}
}
