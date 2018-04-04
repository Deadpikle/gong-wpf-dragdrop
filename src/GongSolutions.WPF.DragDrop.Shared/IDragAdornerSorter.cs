using System;
using System.Collections;

namespace GongSolutions.WPF.DragDrop.Shared
{
  /// <summary>
  /// Interface for objects that sort an IEnumerable of drag drop items
  /// </summary>
  public interface IDragEnumerableSorter
  {
    /// <summary>
    /// Sort the IEnumerable of items
    /// </summary>
    /// <param name="items"></param>
    /// <returns></returns>
    IEnumerable SortDragDropItems(IEnumerable items);
  }
}
