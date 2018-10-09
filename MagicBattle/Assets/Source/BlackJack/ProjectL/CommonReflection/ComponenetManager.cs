using System;
using System.Collections.Generic;
using System.Reflection;

namespace BlackJack.ProjectL.CommonReflection
{
	// Token: 0x02000443 RID: 1091
	public class ComponenetManager<ComponentType> where ComponentType : class, IComponentBase
	{
		// Token: 0x06003FDC RID: 16348 RVA: 0x00128148 File Offset: 0x00126348
		public ComponenetManager(IComponentOwner owner)
		{
			this.m_owner = owner;
		}

		// Token: 0x06003FDD RID: 16349 RVA: 0x00128178 File Offset: 0x00126378
		public T Add<T>() where T : class, IComponentBase, new()
		{
			ComponentType componentType = Activator.CreateInstance<T>() as ComponentType;
			string name = componentType.GetName();
			ComponentType componentType2;
			if (this.m_components.TryGetValue(name, out componentType2))
			{
				return (T)((object)null);
			}
			this.m_components.Add(name, componentType);
			Type typeFromHandle = typeof(T);
			MethodInfo method = typeFromHandle.GetMethod("Tick");
			if (method != null)
			{
				ComponenetManager<ComponentType>.TickableComponentWrapper value = new ComponenetManager<ComponentType>.TickableComponentWrapper
				{
					Component = componentType,
					TickMethodInfo = method
				};
				this.m_tickableComponents.Add(typeFromHandle, value);
			}
			this.m_type2Name.Add(typeof(T), name);
			componentType.Owner = this.m_owner;
			componentType.Init();
			return componentType as T;
		}

		// Token: 0x06003FDE RID: 16350 RVA: 0x00128260 File Offset: 0x00126460
		public void Remove<T>() where T : class, IComponentBase
		{
			T component = this.GetComponent<T>();
			if (component != null)
			{
				this.OnRemove(component);
			}
		}

		// Token: 0x06003FDF RID: 16351 RVA: 0x0012828C File Offset: 0x0012648C
		public T GetComponent<T>() where T : class, IComponentBase
		{
			Type typeFromHandle = typeof(T);
			string key;
			if (this.m_type2Name.TryGetValue(typeFromHandle, out key))
			{
				ComponentType componentType;
				if (this.m_components.TryGetValue(key, out componentType))
				{
					return componentType as T;
				}
			}
			else
			{
				MethodInfo method = typeFromHandle.GetMethod("GetName");
				if (method != null)
				{
					object obj = Activator.CreateInstance(typeFromHandle);
					key = (method.Invoke(obj, null) as string);
					ComponentType componentType;
					if (this.m_components.TryGetValue(key, out componentType))
					{
						return componentType as T;
					}
				}
			}
			return (T)((object)null);
		}

		// Token: 0x06003FE0 RID: 16352 RVA: 0x00128334 File Offset: 0x00126534
		public ComponentType GetComponent(string componentName)
		{
			ComponentType result;
			if (this.m_components.TryGetValue(componentName, out result))
			{
				return result;
			}
			return (ComponentType)((object)null);
		}

		// Token: 0x06003FE1 RID: 16353 RVA: 0x0012835C File Offset: 0x0012655C
		public List<ComponentType> GetAllcomponents()
		{
			List<ComponentType> list = new List<ComponentType>();
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				list.Add(keyValuePair.Value);
			}
			return list;
		}

		// Token: 0x06003FE2 RID: 16354 RVA: 0x001283C8 File Offset: 0x001265C8
		public bool SerializeComponents<T>(T dest)
		{
			bool flag = false;
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				bool flag2 = flag;
				ComponentType value = keyValuePair.Value;
				flag = (flag2 | value.Serialize<T>(dest));
			}
			return flag;
		}

		// Token: 0x06003FE3 RID: 16355 RVA: 0x0012843C File Offset: 0x0012663C
		public void DeSerializeComponents<T>(T source)
		{
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				ComponentType value = keyValuePair.Value;
				value.DeSerialize<T>(source);
			}
		}

		// Token: 0x06003FE4 RID: 16356 RVA: 0x001284A8 File Offset: 0x001266A8
		public void PostDeSerializeComponents()
		{
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				ComponentType value = keyValuePair.Value;
				value.PostDeSerialize();
			}
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x00128514 File Offset: 0x00126714
		public void Tick(uint deltaMillisecond)
		{
			foreach (KeyValuePair<Type, ComponenetManager<ComponentType>.TickableComponentWrapper> keyValuePair in this.m_tickableComponents)
			{
				ComponenetManager<ComponentType>.TickableComponentWrapper value = keyValuePair.Value;
				value.TickMethodInfo.Invoke(value.Component, new object[]
				{
					deltaMillisecond
				});
			}
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x00128598 File Offset: 0x00126798
		public void PostInitComponents()
		{
			foreach (KeyValuePair<string, ComponentType> keyValuePair in this.m_components)
			{
				ComponentType value = keyValuePair.Value;
				value.PostInit();
			}
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x00128604 File Offset: 0x00126804
		private void OnRemove(IComponentBase component)
		{
			component.DeInit();
			this.m_components.Remove(component.GetName());
			this.m_type2Name.Remove(component.GetType());
			this.m_tickableComponents.Remove(component.GetType());
		}

		// Token: 0x04003023 RID: 12323
		private Dictionary<string, ComponentType> m_components = new Dictionary<string, ComponentType>();

		// Token: 0x04003024 RID: 12324
		private Dictionary<Type, string> m_type2Name = new Dictionary<Type, string>();

		// Token: 0x04003025 RID: 12325
		private Dictionary<Type, ComponenetManager<ComponentType>.TickableComponentWrapper> m_tickableComponents = new Dictionary<Type, ComponenetManager<ComponentType>.TickableComponentWrapper>();

		// Token: 0x04003026 RID: 12326
		private IComponentOwner m_owner;

		// Token: 0x02000444 RID: 1092
		public class TickableComponentWrapper
		{
			// Token: 0x17001113 RID: 4371
			// (get) Token: 0x06003FE9 RID: 16361 RVA: 0x0012864C File Offset: 0x0012684C
			// (set) Token: 0x06003FEA RID: 16362 RVA: 0x00128654 File Offset: 0x00126854
			public ComponentType Component { get; set; }

			// Token: 0x17001114 RID: 4372
			// (get) Token: 0x06003FEB RID: 16363 RVA: 0x00128660 File Offset: 0x00126860
			// (set) Token: 0x06003FEC RID: 16364 RVA: 0x00128668 File Offset: 0x00126868
			public MethodInfo TickMethodInfo { get; set; }
		}
	}
}
