<template>
  <v-app-bar color="primary" density="comfortable" elevate-on-scroll>
    <v-app-bar-nav-icon class="d-lg-none" @click="drawer = !drawer" />
    <v-toolbar-title class="text-h6">
      <RouterLink class="text-white text-decoration-none" to="/">{{ siteName }}</RouterLink>
    </v-toolbar-title>
    <v-spacer />
    <v-text-field
      v-model="searchKey"
      class="mx-2"
      density="compact"
      hide-details
      label="搜索书名、作者"
      variant="solo-inverted"
    />
    <v-btn class="mr-2" icon="mdi-magnify" @click="doSearch" />
    <v-btn class="mr-2" icon @click="toggleTheme">
      <v-icon>{{ themeIcon }}</v-icon>
    </v-btn>
    <RouterLink to="/user/login">
      <v-btn variant="text">登录</v-btn>
    </RouterLink>
    <RouterLink to="/user/register">
      <v-btn variant="text">注册</v-btn>
    </RouterLink>
  </v-app-bar>
</template>

<script setup lang="ts">
  import { computed, ref } from 'vue'
  import { useRouter } from 'vue-router'
  import { useAppStore } from '@/stores/app'

  const searchKey = ref('')
  const router = useRouter()
  const siteName = '小说精品屋'

  function doSearch () {
    if (searchKey.value) {
      router.push(`/search?key=${encodeURIComponent(searchKey.value)}`)
    }
  }

  const appStore = useAppStore()
  const themeIcon = computed(() => appStore.theme === 'dark' ? 'mdi-white-balance-sunny' : 'mdi-weather-night')
  function toggleTheme () {
    appStore.toggleTheme()
  }

  const drawer = ref(false)
</script>
