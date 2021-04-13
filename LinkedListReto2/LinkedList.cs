﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListReto2
{
    class LinkedList
    {
        public static readonly int AFTER = 1;
        public static readonly int BEFORE = 0;

        private Node head;
        private Node tail;
        private int size;

        public void add(int data)
        {
            Node node = new Node(data);

            node.setPrevious(tail);

            if (tail != null)
            {
                tail.setNext(node);
            }

            if (head == null)
            {
                head = node;
            }

            tail = node;
            size++;
        }

        public int getSize()
        {
            return size;
        }

        public int get(int index)
        {
            Node currentNode = head;
            int currentIndex = 0;

            while (currentNode != null && currentIndex < index)
            {
                currentNode = currentNode.getNext();
                currentIndex++;
            }

            return currentNode.getData();
        }

        public void delete(int index)
        {
            Node currentNode = head;
            int currentIndex = 0;

            if (index < 0 || index >= size)
            {
                return;
            }

            size--;

            if (size == 0)
            {
                head = null;
                tail = null;
                return;
            }

            if (index == 0)
            {
                head = head.getNext();
                head.setPrevious(null);
            }

            if (index == size - 1)
            {
                tail = tail.getPrevious();
                tail.setNext(null);
            }

            if (index > 0 && index < size - 1)
            {
                while (currentNode != null && currentIndex < index)
                {
                    currentNode = currentNode.getNext();
                    currentIndex++;
                }
                currentNode.getPrevious().setNext(currentNode.getNext());
                currentNode.getNext().setPrevious(currentNode.getPrevious());
            }
        }

        public Iterator getIterator()
        {
            return new Iterator(head);
        }

        public ReverseIterator getReverseIterator()
        {
            return new ReverseIterator(tail);
        }

        public void insert(int data, int position, Iterator it)
        {
            Node newNode = new Node(data);
            Node currentNode = it.getCurrentNode();

            size++;

            if (position == AFTER)
            {
                newNode.setNext(currentNode.getNext());

                currentNode.setNext(newNode);

                if (newNode.getNext() != null)
                {
                    newNode.setPrevious(currentNode);
                    newNode.getNext().setPrevious(newNode);
                }
                else
                {
                    newNode.setNext(null);
                }
            }
            else if (position == BEFORE)
            {
                newNode.setPrevious(currentNode.getPrevious());
                newNode.setNext(currentNode);
                currentNode.setPrevious(newNode);

                if (newNode.getPrevious() != null)
                {
                    newNode.getPrevious().setNext(newNode);
                }
                else
                {
                    newNode.setPrevious(null);
                }
            }

        }
    }
}

