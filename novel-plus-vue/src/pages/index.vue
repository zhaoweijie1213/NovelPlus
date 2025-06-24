<template>
  <v-container class="py-4" fluid>
    <v-row>
      <v-col cols="12" md="8">
        <v-carousel height="300">
          <v-carousel-item v-for="(item, i) in carouselItems" :key="i" :src="item.src" />
        </v-carousel>

        <h2 class="text-h6 font-weight-bold mt-8 mb-4">热门推荐</h2>
        <v-row>
          <v-col
            v-for="book in hotBooks"
            :key="book.id"
            cols="12"
            md="6"
          >
            <v-card :href="book.href" rounded="lg" :subtitle="book.author" :title="book.name">
              <v-img height="160" :src="book.cover" />
            </v-card>
          </v-col>
        </v-row>
      </v-col>
      <v-col cols="12" md="4">
        <v-sheet class="pa-4" elevation="1">
          <h3 class="text-h6 font-weight-bold mb-2">本周强推</h3>
          <v-list density="compact">
            <v-list-item
              v-for="book in weekBooks"
              :key="book.id"
              :subtitle="book.author"
              :title="book.name"
            />
          </v-list>
        </v-sheet>
      </v-col>
    </v-row>

    <h2 class="text-h6 font-weight-bold mt-8 mb-4">精品推荐</h2>
    <v-row>
      <v-col
        v-for="book in classicBooks"
        :key="book.id"
        cols="12"
        md="3"
        sm="6"
      >
        <v-card :href="book.href" rounded="lg" :subtitle="book.author" :title="book.name">
          <v-img height="200" :src="book.cover" />
        </v-card>
      </v-col>
    </v-row>

    <h2 class="text-h6 font-weight-bold mt-8 mb-2">最新更新</h2>
    <v-table density="comfortable">
      <thead>
        <tr>
          <th class="text-left">类别</th>
          <th class="text-left">书名</th>
          <th class="text-left">最新章节</th>
          <th class="text-left">作者</th>
          <th class="text-left">更新时间</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="book in latestBooks" :key="book.id">
          <td>{{ book.cat }}</td>
          <td>{{ book.name }}</td>
          <td>{{ book.lastIndex }}</td>
          <td>{{ book.author }}</td>
          <td>{{ book.updateTime }}</td>
        </tr>
      </tbody>
    </v-table>
  </v-container>
</template>

<script lang="ts" setup>
  interface Book {
    id: number
    name: string
    author: string
    cover: string
    href: string
  }

  interface UpdateBook extends Book {
    cat: string
    lastIndex: string
    updateTime: string
  }

  const carouselItems = [
    { src: '/images/smlcover.png' },
    { src: '/images/smlcover.png' },
    { src: '/images/smlcover.png' },
  ]

  const hotBooks: Book[] = [
    { id: 1, name: '范例小说一', author: '作者A', cover: '/images/smlcover.png', href: '#' },
    { id: 2, name: '范例小说二', author: '作者B', cover: '/images/smlcover.png', href: '#' },
    { id: 3, name: '范例小说三', author: '作者C', cover: '/images/smlcover.png', href: '#' },
    { id: 4, name: '范例小说四', author: '作者D', cover: '/images/smlcover.png', href: '#' },
  ]

  const weekBooks: Book[] = [
    { id: 5, name: '本周推荐一', author: '作者E', cover: '/images/smlcover.png', href: '#' },
    { id: 6, name: '本周推荐二', author: '作者F', cover: '/images/smlcover.png', href: '#' },
    { id: 7, name: '本周推荐三', author: '作者G', cover: '/images/smlcover.png', href: '#' },
  ]

  const classicBooks: Book[] = [
    { id: 8, name: '精品小说一', author: '作者H', cover: '/images/smlcover.png', href: '#' },
    { id: 9, name: '精品小说二', author: '作者I', cover: '/images/smlcover.png', href: '#' },
    { id: 10, name: '精品小说三', author: '作者J', cover: '/images/smlcover.png', href: '#' },
    { id: 11, name: '精品小说四', author: '作者K', cover: '/images/smlcover.png', href: '#' },
  ]

  const latestBooks: UpdateBook[] = [
    { id: 12, name: '更新小说一', author: '作者L', cover: '/images/smlcover.png', href: '#', cat: '玄幻', lastIndex: '第一章', updateTime: '06-24' },
    { id: 13, name: '更新小说二', author: '作者M', cover: '/images/smlcover.png', href: '#', cat: '仙侠', lastIndex: '第二章', updateTime: '06-24' },
    { id: 14, name: '更新小说三', author: '作者N', cover: '/images/smlcover.png', href: '#', cat: '都市', lastIndex: '第三章', updateTime: '06-24' },
  ]
</script>
