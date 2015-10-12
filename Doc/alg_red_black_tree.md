
# Red Black Tree

## 유튜브에도 자료가 많다
https://www.youtube.com/watch?v=PhY56LpCtP4


* A node is either red or black.
* The root is black. This rule is sometimes omitted. Since the root can always be changed from red to black, but not necessarily vice versa, this rule has little effect on analysis.
* All leaves (NIL) are black.
* If a node is red, then both its children are black.
* Every path from a given node to any of its descendant NIL nodes contains the same number of black nodes. The uniform number of black nodes in the paths from root to leaves is called the black-height of the red–black tree.[14]

검정과 빨강이 번갈아 나온다고 생각하면 된다.

## Insert

RB 트리에서는 종단 노드는 항상 비어 있고 블랙이다.
삽입할 때는 빨강으로 한다.


## Delete

# LLRB 트리

2-3 트리의 한 노드를 레드 링크로 연결된 것으로 생각하고 RB 트리의 Insert, Delete를 만든다.
보다 간결한 동작을 구현한다. RB를 발견한 Robert Sedgewick이 다시 2008년에 정리한 내용이다.
1976년에 개선한 내용을 수정했으니 1946년 생이라 63세에 만든 내용인데 대단하다.
