using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

namespace Undercooked
{
    /// <summary>
    /// Structures that the user can highlight and optionally interact with.
    /// Could allow certain items to be dropped/pickedup <see cref="IPickable"/>s into it.
    /// </summary>
    [RequireComponent(typeof(Collider))]
    public abstract class Interactable : MonoBehaviour
    {
        [Tooltip("Pivot where IPickables could be dropped/pickedUp")]
        [SerializeField] protected Transform slot;
        // TODO: we may have a starting item.
        public IPickable CurrentPickable { get; set; }
        protected List<IPickable> _pickables = new List<IPickable>();

        private readonly List<MeshRenderer> _meshes = new List<MeshRenderer>();
        private MaterialPropertyBlock _materialBlock;
        private static readonly int Highlight = Shader.PropertyToID("Highlight_");
        
        public virtual bool IsEmpty() => _pickables.Count == 0;
        public List<IPickable> Pickables => _pickables;
        public Transform Slot => slot;
        
        protected virtual void Awake()
        {
            _materialBlock = new MaterialPropertyBlock();

            CacheMeshRenderers();
            CheckSlotOccupied();
        }

        private void CacheMeshRenderers()
        {
            var baseMesh = transform.GetComponent<MeshRenderer>();
            if (baseMesh != null) _meshes.Add(baseMesh);
            var childMeshes = transform.GetComponentsInChildren<MeshRenderer>();
            foreach (var mesh in childMeshes)
            {
                _meshes.Add(mesh);
            }
        }

        private void CheckSlotOccupied()
        {
            if (Slot == null) return;
            foreach (Transform child in Slot)
            {
                CurrentPickable = child.GetComponent<IPickable>();
                if (CurrentPickable != null) return;
            }
        }

        private void ChangePropertyBlock(bool highlight)
        {
            _materialBlock?.SetInt(Highlight, highlight ? 1 : 0);
            foreach (var mesh in _meshes)
            {
                mesh?.SetPropertyBlock(_materialBlock);
            }
        }

        public virtual void Interact() {}
        
        public virtual void ToggleHighlightOn()
        {
            ChangePropertyBlock(true);
            var interactable = CurrentPickable as Interactable;
            interactable?.ToggleHighlightOn();
        }

        public virtual void ToggleHighlightOff()
        {
            ChangePropertyBlock(false);
            var interactable = CurrentPickable as Interactable;
            interactable?.ToggleHighlightOff();
        }

        public abstract bool TryToDropIntoSlot(IPickable pickableToDrop);
        [CanBeNull] public abstract IPickable TryToPickUpFromSlot(IPickable playerHoldPickable);
    }
}